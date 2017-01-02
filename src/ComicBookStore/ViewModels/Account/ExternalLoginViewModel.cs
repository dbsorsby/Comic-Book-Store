using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookStore.ViewModels.Account
{
    public class ExternalLoginViewModel
    {
        public string AuthenticationScheme { get; set; }

        public string DisplayName { get; set; }
    }
}
