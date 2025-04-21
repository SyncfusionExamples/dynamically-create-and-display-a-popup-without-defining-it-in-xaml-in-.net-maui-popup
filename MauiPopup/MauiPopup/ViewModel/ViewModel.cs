using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiPopup
{
    public class PopupViewModel
    {
        public ICommand ButtonCommand { get; set; }

        public PopupViewModel()
        {
            ButtonCommand = new Command(ExecuteButtonCommand);
        }

        private void ExecuteButtonCommand(object obj)
        {
            PopupHelper.Popup.Show();
        }
    }
}
