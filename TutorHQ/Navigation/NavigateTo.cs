using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorHQ.Navigation
{
    public class NavigateTo
    {
        public static void To<T>(Form currentForm) where T : Form, new()
        {
            currentForm.Hide();

            var newForm = CreateForm<T>(currentForm);
            newForm.Show();
        }

        private static T CreateForm<T>(Form currentForm) where T : Form, new()
        {
            T newForm = new T();

            newForm.Closed += (s, args) => currentForm.Close();
            newForm.WindowState = currentForm.WindowState;

            return newForm;
        }
    }

}
