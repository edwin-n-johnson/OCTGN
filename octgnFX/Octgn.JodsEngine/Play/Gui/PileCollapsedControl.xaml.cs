﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Octgn.DataNew.Entities;

namespace Octgn.Play.Gui
{
    public partial class PileCollapsedControl
    {
        public PileCollapsedControl()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            e.Handled = true;

            // Fix: capture the group, because it's sometimes null inside the Completed event.
            var oldPile = (Pile) group;
            // Fix: group may even be null at this point (?!). 
            // Apparently when clicking on a pile just after another one has been removed. That would be just before the GroupChanged happens?
            if (oldPile == null) return;

            var anim = new DoubleAnimation(0, TimeSpan.FromMilliseconds(300))
                           {EasingFunction = new ExponentialEase {EasingMode = EasingMode.EaseIn}};
            anim.Completed += delegate
                                  {
                                      oldPile.ViewState = DataNew.Entities.GroupViewState.Pile;
                                  };

            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
        }

        protected override void OnCardOver(object sender, CardsEventArgs e)
        {
            base.OnCardOver(sender, e);
			for(var i = 0;i<e.Cards.Length;i++)
            {
                e.CardSizes[i] = new Size(e.Cards[i].RealWidth * 30 / e.Cards[i].RealHeight, 30);
            }
            //e.CardSize = new Size(30*group.Def.Width/group.Def.Height, 30);
        }

        protected override void OnCardDropped(object sender, CardsEventArgs e)
        {
            e.Handled = e.CanDrop = true;
            //if (group.TryToManipulate())
            //{ 
            //    foreach (Card c in e.Cards)
            //        c.MoveTo(group, e.FaceUp != null && e.FaceUp.Value, 0,false);
            //}
            if (group.TryToManipulate())
            {
                var cards = e.Cards.ToArray();
                Card.MoveCardsTo(group, cards, 
                    Enumerable.Repeat(e.FaceUp ?? false,cards.Length).ToArray()
                    ,Enumerable.Repeat(0,cards.Length).ToArray(),false);
            }
        }
    }
}