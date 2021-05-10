using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
    public partial class TripsGUI : Form
    {
        Queue q1 = new Queue();

        public TripsGUI()
        {
            InitializeComponent();

        }


        private void btnAdd_Click(object sender, EventArgs e) //לחצן הוספת טיול
        {
            Trip t;
            if (txtDest.Text == "") // ממקד קלט על היעד, במידה ולא הוכנס
            {
                MessageBox.Show("Insert destination");
                txtDest.Focus();
                return;
            }
            if (txtDate.Text == "") // ממקד קלט על התאריך, במידה ולא הוכנס
            {
                MessageBox.Show("Insert date");
                txtDate.Focus();
                return;
            }
            if (txtType.Text == "") // ממקד קלט על סוג הטיול, במידה ולא הוכנס
            {
                MessageBox.Show("Insert type");
                txtType.Focus();
                return;
            }
            // כדי למנוע מספור לא תקין של הטיולים, בודקים האם הטיול קיים לפני שיוצרים אותו (מספר הטיול גודל באחד כאשר מפעילים בנאי).
            if (!q1.TripExists(DateTime.Parse(txtDate.Text), (TripType)Enum.Parse(typeof(TripType), txtType.Text))) 
            {
                t = new Trip();
                t.TripType = (TripType)Enum.Parse(typeof(TripType), txtType.Text);
                t.Destination = txtDest.Text;
                t.Date = DateTime.Parse(txtDate.Text);               
                q1.Enqueue(t);
                txtDate.Text = "";
                txtDest.Text = "";
                txtType.Text = "";
                TripList.Items.Clear();
                foreach (Trip trip in q1.Arr)
                {
                    if (trip != null)
                    {
                        TripList.Items.Add(trip.PrintTripForGUI());

                    }
                }
                TripList.Visible = true; // עדכון רשימת הטיולים למצב נראות
            }
            else
            {
                MessageBox.Show("Trip already exists!");              
                return;
            }
            
        }
    
            
            
           
        

        private void btnDelete_Click(object sender, EventArgs e) // מחיקת טיול הבא
        {
            if (!q1.IsEmpty())
            {
                q1.Dequeue();
               
                TripList.Items.Clear();// ניקוי הרשימה הקיימת

                foreach (Trip trip in q1.Arr)
                {
                    if (trip!=null)
                    {
                        TripList.Items.Add(trip.PrintTripForGUI()); // הצגת הטיולים

                    }
                }
            }
            else MessageBox.Show("Queue is empty!","Empty queue", MessageBoxButtons.OK);



        }

        

        private void btnDest_Click(object sender, EventArgs e) // מתודה זו מאפשרת להציג טיולים לפי היעד
        {
            TripList.Items.Clear(); // ניקוי הרשימה הקיימת
            if (q1.IsEmpty())
            {
                MessageBox.Show("Queue is empty!");
                return;
            }
            else
            {
                if (txtShowDest.Text=="")
                {
                    MessageBox.Show("Enter destination");
                    txtShowDest.Focus();
                }
                else
                {
                    foreach (Trip trip in q1.Arr)
                    {
                        if (trip.Destination == txtShowDest.Text)
                        {
                            TripList.Items.Add(trip.PrintTripForGUI()); // הדפסת הטיולים הרלוונטים
                        }
                    }
                }
                
            }
        }
    }
}
