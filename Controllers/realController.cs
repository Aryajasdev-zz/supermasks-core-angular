using Microsoft.AspNetCore.Mvc;
using supermasks.biz;
using supermasks.Core;
using System;

namespace supermasks.Controllers
{
    [Produces("application/json")]    
    public class realController : Controller
    {
        private readonly IUnitOfWork _context;
        public realController(IUnitOfWork context)
        {
            _context = context;
        }

        [Route("api/GetRealRequest")]
        [HttpGet]
        public IActionResult GetRealReq()
        {
            String timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            String Orderid = Guid.NewGuid().ToString();
            Int32 amount = Convert.ToInt32(0.01 * 100);
            String tmp = timestamp + '.' + Global.Merchantidtest + '.' + Orderid + '.' + amount + '.' + "GBP";
            String sha1hash = _context.Common.SHA1Hash(tmp);
            tmp = sha1hash + '.' + Global.Secrettest;
            sha1hash = _context.Common.SHA1Hash(tmp);
            realrequest real = new realrequest() {
                MERCHANT_ID = Global.Merchantidtest,
                ACCOUNT = Global.Accounttest,
                ORDER_ID = Orderid,
                AMOUNT = amount.ToString(),
                CURRENCY = "GBP",
                TIMESTAMP = timestamp,
                SHA1HASH = sha1hash,
                AUTO_SETTLE_FLAG = "1",
                COMMENT1 = "realex Payment",
                COMMENT2 = "realex payment",
                RETURN_TSS = "0",
                SHIPPING_CODE ="",
                SHIPPING_CO ="",
                BILLING_CODE ="",
                BILLING_CO = "",
                CUST_NUM = Orderid,
                VAR_REF = Orderid,
                PROD_ID = Orderid,
                HPP_LANG = "EN",
                CARD_PAYMENT_BUTTON = "Submit Payment",
                CARD_STORAGE_ENABLE = "0",
                OFFER_SAVE_CARD = "0",
                PAYER_REF = Orderid,
                PMT_REF = Orderid,
                PAYER_EXIST = "0",
                VALIDATE_CARD_ONLY = "0", 
                DCC_ENABLE = "0",
                HPP_SELECT_STORED_CARD = Orderid
            };
            return Ok(real);
        }

        [Route("api/GetRealResponse")]
        [HttpPost]
        public IActionResult GetRealRes([FromBody] realresponse items)
        {            
            return Ok(items);
        }
    }
}