namespace OpenClosed.Before
{
    internal class ShapeDrawer 
    {
        public void DrawShape(object shape)
        {
            if (shape is Rectangle)
            {
                var rectangle = (Rectangle)shape;
                // draw rectangle

            }
            else if (shape is Square)
            {
                var square = (Square)shape;
                // draw square
            }
        }// in this case if we want to add a new shape we have to modify this class which is against the Open/Closed principle
    }

}
