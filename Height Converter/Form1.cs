namespace Height_Converter
{
    public partial class Form1 : Form
    {

        //Constant values for feet and inch conversion to meters
        private const double FEET_TO_METER = 0.3048;
        private const double INCHES_TO_METER = 0.0254;

        public Form1()
        {
            InitializeComponent();
        }

        private void meterConversionButton_Click(object sender, EventArgs e)
        {
            //Try method to catch any unwanted inputs from converter (both non-numerical and non-integer inputs)
            try
            {
                //get integers for feet and inches from textboxes
                int feet = int.Parse(heightFeetTextbox.Text);
                int inches = int.Parse(heightInchesTextbox.Text);

                if (inches >= 0 && inches <= 11)
                {
                    if (feet >= 0)
                    {
                        //uses constant values to multiply feet and inches into meter format;
                        //1ft = 0.3048m, 1in = 0.0254m;
                        //after converting feet and inches to meters separately, adds together to get total height in meters
                        double meters = (feet * FEET_TO_METER) + (inches * INCHES_TO_METER);

                        //displays meters to 3 decimal places in form
                        meterHeightLabel.Text = "You are " + meters.ToString("n3") + "m tall!";
                    }
                    else
                    {
                        MessageBox.Show("ERROR! Please make sure you put in a positive amount of feet!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("ERROR! Please make sure you put inches between 0-11");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}