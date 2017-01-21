using System;
using System.Windows.Forms;

namespace BridgeProblem
{
    public partial class Form1 : Form
    {
        private static Form1 form;

        public Form1()
        {
            InitializeComponent();
            form = this;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Simulation sim = new Simulation();

            int numberOfRightCars = (int) nuRight.Value;
            int numberOfLeftCars = (int) nuLeft.Value;

            log.Clear();

            //Simulation entry point
            sim.RunSim(numberOfRightCars, numberOfLeftCars);
        }

        //Thread-safe adds message to log
        public static void AddToLog(string msg)
        {
            form.AddMsgToLog(msg + "\n");
        }

        public void AddMsgToLog(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AddToLog), new object[] { value });
                return;
            }
            log.Text += value;
        }
    }
}
