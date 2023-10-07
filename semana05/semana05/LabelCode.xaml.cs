using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelCode : ContentPage
    {
        public LabelCode()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();

            var UnderlineLabel = new Label
            {
                Text = "This is underlined text.",
                TextDecorations = TextDecorations.Underline
            };

            var strikethroughLabel = new Label
            {
                Text = "This is text with strikethroughLabel.",
                TextDecorations = TextDecorations.Strikethrough
            };

            var bothLabel = new Label
            {
                Text = "This is underlined text with strikethrough. ",
                TextDecorations = TextDecorations.Underline | TextDecorations.Strikethrough
            };

            stack.Children.Add(UnderlineLabel);
            stack.Children.Add(strikethroughLabel);
            stack.Children.Add(bothLabel);

            Content = stack;

        }
    }
}