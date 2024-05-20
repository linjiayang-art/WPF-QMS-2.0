using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS.Core
{
    public class DialogViewModel : BindableBase, IDialogAware
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        public event Action<IDialogResult> RequestClose;


        /// <summary>
        /// 是否可以关闭对话框
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {

        }
    }
}
