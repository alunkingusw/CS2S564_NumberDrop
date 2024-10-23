namespace NumberDrop
{
    public partial class frmDragDropCalculator : Form
    {
        //create a variable to keep track of the total.
        decimal total = 0;
        public frmDragDropCalculator()
        {
            InitializeComponent();
        }

        private void lblNumOne_MouseDown(object sender, MouseEventArgs e)
        {
            //start the drag effect by saving the tag to the RAM.
            lblNumOne.DoDragDrop(lblNumOne.Tag, DragDropEffects.Move);
        }

        private void lblSubTarget_DragDrop(object sender, DragEventArgs e)
        {
            //get the data from the RAM, convert to a decimal.
            decimal number = decimal.Parse((string)e.Data.GetData(DataFormats.StringFormat));
            //subtract from the total
            total = total - number;
            //update the label
            lblTotal.Text = total + "";
        }

        private void lblSubTarget_DragEnter(object sender, DragEventArgs e)
        {
            //allow DragDrops that are using the Move effect only.
            e.Effect = DragDropEffects.Move;
        }

        private void lblAddTarget_DragEnter(object sender, DragEventArgs e)
        {
            //allow DragDrops that are using the Move effect only.
            e.Effect = DragDropEffects.Move;
        }

        private void lblAddTarget_DragDrop(object sender, DragEventArgs e)
        {
            //get the data from the RAM, convert to a decimal.
            decimal number = decimal.Parse((string)e.Data.GetData(DataFormats.StringFormat));
            //subtract from the total
            total = total + number;
            //update the label
            lblTotal.Text = total + "";
        }
    }
}
