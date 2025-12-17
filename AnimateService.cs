using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryDash.BLL
{
    public class AnimateService
    {
        // Tracks animations per control so they don't interfere with each other
        private readonly Dictionary<Control, CancellationTokenSource> _activeAnimations = new Dictionary<Control, CancellationTokenSource>();

        public async Task FadeControl(Control control, bool isEntering)
        {
            // 1. Cancel any existing animation for THIS specific control
            if (_activeAnimations.TryGetValue(control, out var existingCts))
            {
                existingCts.Cancel();
                _activeAnimations.Remove(control);
            }

            var cts = new CancellationTokenSource();
            _activeAnimations[control] = cts;
            var token = cts.Token;

            // 2. Define Targets
            // Background: PapayaWhip (Alpha 55) vs Transparent (Alpha 0)
            // Text: 100% (Alpha 255) vs 25% (Alpha 64)
            int targetBgAlpha = isEntering ? 55 : 0;
            int targetTextAlpha = isEntering ? 255 : 64;

            // Adjust 'step' for snappiness. 5-10 is usually a sweet spot for 15ms delay.
            int step = 8;

            try
            {
                while (true)
                {
                    if (token.IsCancellationRequested) return;

                    bool bgDone = false;
                    bool textDone = false;

                    // --- Background Animation ---
                    int currentBg = control.BackColor.A;
                    if (currentBg != targetBgAlpha)
                    {
                        int nextBg = isEntering
                            ? Math.Min(targetBgAlpha, currentBg + step)
                            : Math.Max(targetBgAlpha, currentBg - step);
                        control.BackColor = Color.FromArgb(nextBg, Color.PapayaWhip);
                    }
                    else { bgDone = true; }

                    // --- Text Animation (Stored in Tag for Paint Event) ---
                    int currentTxt = (control.Tag is int val) ? val : 64;
                    if (currentTxt != targetTextAlpha)
                    {
                        currentTxt = isEntering
                            ? Math.Min(targetTextAlpha, currentTxt + step)
                            : Math.Max(targetTextAlpha, currentTxt - step);
                        control.Tag = currentTxt;
                        control.Invalidate(); // Forces the Paint event to fire
                    }
                    else { textDone = true; }

                    if (bgDone && textDone) break;

                    await Task.Delay(15);
                }
            }
            catch (ObjectDisposedException) { }
            finally
            {
                // Final Cleanup: ensure states are exactly at target if not cancelled
                if (!token.IsCancellationRequested)
                {
                    if (!isEntering)
                    {
                        control.BackColor = Color.Transparent;
                        control.Tag = 64;
                    }
                    else
                    {
                        control.BackColor = Color.FromArgb(targetBgAlpha, Color.PapayaWhip);
                        control.Tag = 255;
                    }
                    control.Invalidate();
                    _activeAnimations.Remove(control);
                }
            }
        }
    }
}