﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace ControlInventario.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NUEVA CONTRASEÑA")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "CONFIRME SU NUEVA CONTRASEÑA")]
        [Compare("NewPassword", ErrorMessage = "LAS CONTRASEÑAS NO COINCIDEN")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "CONTRASEÑA ACTUAL")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NUEVA CONTRASEÑA")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "CONFIRME LA CONTRASEÑA")]
        [Compare("NUEVA CONTRASEÑA", ErrorMessage = "LAS CONTRASEÑAS NO COINCIDEN.")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "NÚMERO DE TELÉFONO")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "CÓDIGO")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "NÚMERO DE TELÉFONO")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}