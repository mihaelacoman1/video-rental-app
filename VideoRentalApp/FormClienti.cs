using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalApp
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            this.Load += FormClient_Load;
            this.buttonSterge.Click += buttonStergeClient_Click;
            this.buttonEditeaza.Click += buttonEditeazaClient_Click;
            this.buttonAdauga.Click += buttonAdauga_Click;

            this.textBoxNume.Enter += textBoxNume_Enter;
            this.textBoxEmail.Enter += textBoxEmail_Enter;
            this.listBoxClienti.SelectedIndexChanged += listBoxClienti_SelectedIndexChanged;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            AfiseazaClienti();
        }

        private void AfiseazaClienti()
        {
            listBoxClienti.Items.Clear();

            string query = "SELECT * FROM Clienti";
            DataTable dt = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Client c = new Client
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nume = row["Nume"].ToString(),
                    Email = row["Email"].ToString()
                };
                listBoxClienti.Items.Add(c);
            }
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string nume = textBoxNume.Text.Trim();
            string email = textBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            string query = "INSERT INTO Clienti (Nume, Email) VALUES (@Nume, @Email)";
            var parameters = new Dictionary<string, object>
            {
                {"@Nume", nume},
                {"@Email", email}
            };

            DbHelper.ExecuteNonQuery(query, parameters);
            AfiseazaClienti();
            textBoxNume.Clear();
            textBoxEmail.Clear();
        }

        private void buttonEditeazaClient_Click(object sender, EventArgs e)
        {
            if (listBoxClienti.SelectedItem == null)
            {
                MessageBox.Show("Selectează un client pentru editare!");
                return;
            }

            string nume = textBoxNume.Text.Trim();
            string email = textBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            Client clientSelectat = (Client)listBoxClienti.SelectedItem;
            string query = "UPDATE Clienti SET Nume = @Nume, Email = @Email WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                {"@Nume", nume},
                {"@Email", email},
                {"@Id", clientSelectat.Id}
            };

            DbHelper.ExecuteNonQuery(query, parameters);
            AfiseazaClienti();
        }

        private void buttonStergeClient_Click(object sender, EventArgs e)
        {
            if (listBoxClienti.SelectedItem == null)
            {
                MessageBox.Show("Selectează un client pentru ștergere!");
                return;
            }

            Client clientSelectat = (Client)listBoxClienti.SelectedItem;
            string query = "DELETE FROM Clienti WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                {"@Id", clientSelectat.Id}
            };

            DbHelper.ExecuteNonQuery(query, parameters);
            AfiseazaClienti();
        }

        private void listBoxClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClienti.SelectedItem is Client c)
            {
                textBoxNume.Text = c.Nume;
                textBoxEmail.Text = c.Email;
            }
        }

        private void textBoxNume_Enter(object sender, EventArgs e) => textBoxNume.Clear();
        private void textBoxEmail_Enter(object sender, EventArgs e) => textBoxEmail.Clear();
    }
}
