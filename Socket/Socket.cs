using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Socket servidor; //Objecte global de la classe socket

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Connecta_Click(object sender, EventArgs e)
        {

            IPAddress direc = IPAddress.Parse("192.168.56.104"); //Creem l'estructura para la IP del servidor
            IPEndPoint ipep = new IPEndPoint(direc, 9030);//Creem un IPEndPoint

            servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//Creem el socket amb el tipus de xarxa i el tipus de protocol
            try
            {
                servidor.Connect(ipep); //Establim connexió
                this.BackColor = Color.Green;
                MessageBox.Show("Connectat");
            }
            catch (SocketException ex)
            {
                MessageBox.Show("No s'ha pogut establir connexió amb el servidor");
                return;
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {


            if (Longitud.Checked)
            {
                string missatge = "1/" + Nom.Text;//Enviem el missatge amb la capçalera
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);//Convertim el missatge en un vector de bytes
                servidor.Send(msg);//Enviem el vector de bytes

                byte[] msg2 = new byte[80];//Rebem la resposta del servidor com a vector de bytes
                servidor.Receive(msg2);//Obtenim la resposta
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];//Transformem el vector de bytes de la resposta a un string i li traiem la brossa tallant en el marcador
                MessageBox.Show("La longitud del missatge és: " + missatge);

            }
            else if (Maco.Checked)
            {
                string missatge = "2/" + Nom.Text;//Enviem el missatge amb la capçalera
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);//Convertim el missatge en un vector de bytes
                servidor.Send(msg);//Enviem el vector de bytes

                byte[] msg2 = new byte[80];//Rebem la resposta del servidor com a vector de bytes
                servidor.Receive(msg2);//Obtenim la resposta
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];//Transformem el vector de bytes de la resposta a un string i li traiem la brossa tallant en el marcador

                if (missatge == "Si")
                    MessageBox.Show("El teu nom és maco");
                else
                    MessageBox.Show("El teu nom és lleig");
            }
            else if (Alt.Checked)
            {
                string missatge = "3/" + Nom.Text + "/" + Grandesa.Text;//Enviem el missatge amb la capçalera
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);//Convertim el missatge en un vector de bytes
                servidor.Send(msg);//Enviem el vector de bytes

                byte[] msg2 = new byte[80];//Rebem la resposta del servidor com a vector de bytes
                servidor.Receive(msg2);//Obtenim la resposta
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];//Transformem el vector de bytes de la resposta a un string i li traiem la brossa tallant en el marcador
                MessageBox.Show(missatge);                

            }
            else if (Palindrom.Checked)
            {
                string missatge = "4/" + Nom.Text;//Enviem el missatge amb la capçalera
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);//Convertim el missatge en un vector de bytes
                servidor.Send(msg);//Enviem el vector de bytes

                byte[] msg2 = new byte[80];//Rebem la resposta del servidor com a vector de bytes
                servidor.Receive(msg2);//Obtenim la resposta
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];//Transformem el vector de bytes de la resposta a un string i li traiem la brossa tallant en el marcador

                if (missatge == "Si")
                    MessageBox.Show("El teu nom és palíndrom");
                else
                    MessageBox.Show("El teu nom no és palíndrom");
            }
            else
            {
                string missatge = "5/" + Nom.Text;//Enviem el missatge amb la capçalera
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);//Convertim el missatge en un vector de bytes
                servidor.Send(msg);//Enviem el vector de bytes

                byte[] msg2 = new byte[80];//Rebem la resposta del servidor com a vector de bytes
                servidor.Receive(msg2);//Obtenim la resposta
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];//Transformem el vector de bytes de la resposta a un string i li traiem la brossa tallant en el marcador
                MessageBox.Show(missatge);

            }


        }

        private void Desconnecta_Click(object sender, EventArgs e)
        {
            //S'acaba el servei
            string missatge = "0/";//Missatge de desconnexió
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
            servidor.Send(msg);

            this.BackColor = Color.Gray;
            servidor.Shutdown(SocketShutdown.Both);//Ens desconectem
            servidor.Close();
                                          
        }
    }
}
