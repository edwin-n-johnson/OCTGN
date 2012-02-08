using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SimplestDragDrop
{
    internal class DragAdorner : Adorner
    {
        protected double XCenter;
        protected double YCenter;
        protected UIElement Child;
        private double _leftOffset;
        protected UIElement Owner;
        private double _topOffset;
        public double Scale = 1.0;

        public DragAdorner(UIElement owner) : base(owner)
        {
        }

        public DragAdorner(UIElement owner, UIElement adornElement, bool useVisualBrush, double opacity)
            : base(owner)
        {
            Debug.Assert(owner != null);
            Debug.Assert(adornElement != null);
            Owner = owner;
            if (useVisualBrush)
            {
                var brush = new VisualBrush(adornElement) {Opacity = opacity};
                var r = new Rectangle
                            {
                                RadiusX = 3,
                                RadiusY = 3,
                                Width = adornElement.DesiredSize.Width,
                                Height = adornElement.DesiredSize.Height
                            };

                //TODO: questioning DesiredSize vs. Actual 

                XCenter = adornElement.DesiredSize.Width/2;
                YCenter = adornElement.DesiredSize.Height/2;

                r.Fill = brush;
                Child = r;
            }
            else
                Child = adornElement;
        }


        public double LeftOffset
        {
            get { return _leftOffset; }
            set
            {
                _leftOffset = value - XCenter;
                UpdatePosition();
            }
        }

        public double TopOffset
        {
            get { return _topOffset; }
            set
            {
                _topOffset = value - YCenter;

                UpdatePosition();
            }
        }

        protected override int VisualChildrenCount
        {
            get { return 1; }
        }

        private void UpdatePosition()
        {
            var adorner = (AdornerLayer) Parent;
            if (adorner != null)
            {
                adorner.Update(AdornedElement);
            }
        }

        protected override Visual GetVisualChild(int index)
        {
            return Child;
        }


        protected override Size MeasureOverride(Size finalSize)
        {
            Child.Measure(finalSize);
            return Child.DesiredSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            Child.Arrange(new Rect(Child.DesiredSize));
            return finalSize;
        }

        public override GeneralTransform GetDesiredTransform(GeneralTransform transform)
        {
            var result = new GeneralTransformGroup();

            result.Children.Add(base.GetDesiredTransform(transform));
            result.Children.Add(new TranslateTransform(_leftOffset, _topOffset));
            return result;
        }
    }
}