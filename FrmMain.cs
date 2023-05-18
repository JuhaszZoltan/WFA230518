using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace WFA230518
{
    public partial class FrmMain : Form
    {
        private string ConnectionString { get; set; }

        public FrmMain(string connectionString)
        {

            ConnectionString = connectionString;
            InitializeComponent();
            this.Load += OnFrmMainLoad;
            btnInsert.Click += OnBtnInsertClick;
        }

        private void OnBtnInsertClick(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewName.Text) 
                || dtpNewDoB.Value.Date == DateTime.Today)
            {
                MessageBox.Show("pls fill!");
                return;
            }
            using MySqlConnection conn = new(ConnectionString);
            conn.Open();

            MySqlCommand cmd = new(
                cmdText: "INSERT INTO teszttabla (nev, szul) VALUES " +
                $"('{txtNewName.Text}', '{dtpNewDoB.Value.ToString("yyyy-MM-dd")}');",
                connection: conn);

            MySqlDataAdapter adapter = new()
            {
                InsertCommand = cmd,
            };

            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("done!");

            LoadData();
        }

        private void OnFrmMainLoad(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            rtbConnectionTest.Clear();
            using MySqlConnection conn = new(ConnectionString);
            conn.Open();
            MySqlCommand cmd = new(
                cmdText: "SELECT * FROM teszttabla;",
                connection: conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nev = reader.GetString(1);
                string? szul =
                    reader[2] is DBNull
                    ? null
                    : reader.GetDateTime(2).ToString("yyyy-MM-dd");

                rtbConnectionTest.Text += $"{id,3}\t{nev,-15} {szul}\n";
            }

        }
    }
}