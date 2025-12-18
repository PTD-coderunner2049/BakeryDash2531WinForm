note for winform project

> I dont use builtin datasource for datagridview because I had collum pull from difference tables, and I dont want to make a dedicated class because those collum was minor (role for user for example from staff which only one collum)
so I bind it manually on load()

> _util from UI has one that I used to extend shit from DataGridView, but no inheritance needed, this is some C# magic, apparently it scan when I call this custom method because it dosnt know what it is, then it follow certain convention like DataGridExtension and work itself out LOL.