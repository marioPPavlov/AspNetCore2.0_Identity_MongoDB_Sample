﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._0_Identity_MongoDB_Sample.Models.ManageViewModels
{
    public class TwoFactorAuthenticationViewModel
    {
        public bool HasAuthenticator { get; set; }

        public int RecoveryCodesLeft { get; set; }

        public bool Is2faEnabled { get; set; }
    }
}
