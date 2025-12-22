using SolbergBakery2531.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SolbergBakery2531.UI.UserControls
{
    public partial class ProdCardControl : UserControl
    {
        public Guid ProductId { get; private set; }
        public new string ProductName { get; private set; }
        public int CurrentStock { get; private set; }

        private List<Image> _images = new List<Image>();
        private int _currentImageIndex = 0;
        private Timer _imageTimer;

        public ProdCardControl(Guid productId, string name, int stock)
        {
            InitializeComponent();
            ProductId = productId;
            ProductName = name;
            CurrentStock = stock;

            ItemNameSmall.Text = ProductName;
            SetupImages();
        }

        private void SetupImages()
        {
            DataTable visualData = new ProductService().FetchVisual(ProductId);
            foreach (DataRow row in visualData.Rows)
            {
                byte[] bytes = (byte[])row["VisualinByte"];
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    _images.Add(Image.FromStream(ms));
                }
            }

            if (_images.Count > 0)
            {
                ItemFacePicBox.Image = _images[0];
                ItemFacePicBox.SizeMode = PictureBoxSizeMode.Zoom;

                if (_images.Count > 1)
                {
                    _imageTimer = new Timer();
                    _imageTimer.Interval = 3000;
                    _imageTimer.Tick += (s, e) => {
                        _currentImageIndex = (_currentImageIndex + 1) % _images.Count;
                        ItemFacePicBox.Image = _images[_currentImageIndex];
                    };
                    _imageTimer.Start();
                }
            }
        }

        private void ProdCardControl_Load(object sender, EventArgs e)
        {
            // Pass clicks up to the parent, so the entire card is clickable
            foreach (Control c in this.Controls)
            {
                c.Click += (s, ev) => this.OnClick(ev);
            }
        }
    }
}