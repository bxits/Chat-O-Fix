using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chat_O_Fix
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Kleine Überprüfung, dass auch etwas in den Textfeldern steht.
            if (!String.IsNullOrEmpty(txtAlias.Text) && !String.IsNullOrEmpty(txtQuote.Text))
            {
                //Verbindung zur DB aufbauen.
                MySqlConnection myConnection = 
                    new MySqlConnection("SERVER=10.8.7.87" +
                    ";DATABASE=chatofix;UID=chatofix;PASSWORD=chatofix;");
                myConnection.Open();

                //Einfüge SQL-Befehl zusammenbauen.
                string myInsertQuery = @"INSERT INTO t_chatquote (alias, quote, timestamp)
                    Values('" + txtAlias.Text + "', '" + txtQuote.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "')";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //Dem SQL-Befehl noch sagen, welche Verbindung zum Server verwendet werden soll.
                myCommand.Connection = myConnection;

                //Befehl ausführen.
                myCommand.ExecuteNonQuery();

                //Verbindung zur Datenbank wieder abbauen.
                myConnection.Close();
            }

            txtQuote.Clear();

        }

        private void tmrQuoteChecker_Tick(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection("SERVER=10.8.7.87;DATABASE=chatofix;UID=chatofix;PASSWORD=chatofix;");
                myConnection.Open();

                //Alle Datensätze aus der DB holen per SQL-Befehl.
                string mySelectQuery = "SELECT * FROM t_chatquote";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);

                MySqlDataReader Reader = myCommand.ExecuteReader();

                txtChatQuots.Clear();

                string allMsg = string.Empty; ;

                while (Reader.Read())
                {
                   allMsg += "#" + Reader.GetValue(0).ToString() + " @" + Reader.GetValue(3).ToString() + " von " + Reader.GetValue(1).ToString() + ": " + Reader.GetValue(2).ToString() + Environment.NewLine;
                   
                }
                // txtChatsView.ScrollToCaret();
                txtChatQuots.Text = allMsg;
                txtChatQuots.SelectionStart = txtChatQuots.Text.Length;
                txtChatQuots.ScrollToCaret();
                //Verbindung zur Datenbank wieder abbauen.
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           


        }



    }
}
