using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GLobal_Mouse_Events
{
    public partial class Form1 : Form
    {



        // Get Cursor Postion
        Point Mouse_Position = System.Windows.Forms.Cursor.Position;
        Thread Mouse_Wacher;
        Object My_Lock = new object();



        private void textBox1_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            Key_Press_textBox.Text = e.Key.ToString();
        }



            public Form1()
            {
            InitializeComponent();

            }




        private void Form1_Load(object sender, EventArgs e)
        {


            //System.Windows.Input.Keyboard.KeyDownEvent.ToString(); += new System.Windows.Forms.KeyEventArgs(textBox1_KeyDown);

            //  ItemPanel.MouseDown += new MouseEventHandler(ItemPanel_MouseDown);///Added panel Declaring MouseDown
            Mouse_Wacher_Method();

        }










        // MOUSE LOCATION - THREAD
        private void Mouse_Wacher_Method()
        {
             Mouse_Wacher = new Thread(Mouse_Checker);
            //Mouse_Wacher.SetApartmentState(ApartmentState.STA);
             Mouse_Wacher.IsBackground = true;
             Mouse_Wacher.Start();
        }



  

        // Get Cursor Position
        private void Mouse_Checker()
        {
            lock(My_Lock)
            {

                 while(true)
                 {
                    //if ((Keyboard.GetKeyStates(Key.Return) & KeyStates.Down) > 0)
                    //{
                    //    btnNone.Background = Brushes.Red;
                    //}

                      Mouse_Position = System.Windows.Forms.Cursor.Position;
                      Invoke(new Action(() => { Mouse_Location_X_TextBox.Text = System.Windows.Forms.Cursor.Position.X.ToString(); }));
                      Invoke(new Action(() => { Mouse_Location_Y_TextBox.Text = System.Windows.Forms.Cursor.Position.Y.ToString(); }));
                      //Invoke(new Action(() => { Key_Press_textBox.Text = Control.MousePosition.X.ToString(); }));
                      Invoke(new Action(() => { mouse_key_press_textBox.Text = Control.MouseButtons.ToString(); }));
                      Invoke(new Action(() => { mouse_key_press_textBox.Text = Control.MouseButtons.ToString(); }));
                    //Invoke(new Action(() => { Key_Press_textBox.Text = Control.ModifierKeys.ToString(); }));
                    //Invoke(new Action(() => { textBox1_KeyDown  }));
                    Invoke(new Action(() => { OnKeyPress}));





                    Thread.Sleep(50);
                    
                 }

            }
        }








        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            Key_Press_textBox.Text = e.KeyChar.ToString();
            base.OnKeyPress(e);
        }







    }
}
