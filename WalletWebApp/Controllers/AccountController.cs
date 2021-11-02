using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalletWebApp.Data;

namespace WalletWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController(WalletContext context)
        {
            Context = context;
        }

        WalletContext Context { get; }

        public JsonResult OnGet()
        {
            var accounts = Context.Accounts.ToList();

            return new JsonResult(accounts);
        }
    }
}
