using Cadastro_de_Especies.Helpers;

namespace Cadastro_de_Especies
{
    public partial class App : Application
    {
        static SQLiteDataBaseHelpers _db;
        public static SQLiteDataBaseHelpers Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Especie.db3");

                    _db = new SQLiteDataBaseHelpers(path);
                }
                return _db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
