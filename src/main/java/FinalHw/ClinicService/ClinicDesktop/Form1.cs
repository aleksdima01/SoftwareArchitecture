using ClinicServiceNamespace;

namespace ClinicDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5044/", new HttpClient());
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;

            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                listViewClients.Items.Add(item);
            }
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5044/", new HttpClient());
            ListViewItem item = listViewClients.FocusedItem;
            if (item != null)
            {
                int index = Convert.ToInt32(listViewClients.FocusedItem.SubItems[0].Text);
                Client client = clinicClient.ClientGetByIdAsync(index).Result;
                if (client != null)
                {
                    documentText.Text = client.Document;
                    nameText.Text = client.FirstName;
                    sureNameText.Text = client.SurName;
                    patronymicText.Text = client.Patronymic;
                    birthdayPicker.Value = client.Birthday.LocalDateTime;
                }
            }
        }

        private void getOneBtn_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5044/", new HttpClient());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
