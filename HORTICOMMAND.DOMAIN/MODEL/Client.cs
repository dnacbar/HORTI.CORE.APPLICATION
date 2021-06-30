﻿using HORTI.CORE.CROSSCUTTING.VALUEOBJECT;
using HORTICOMMAND.DOMAIN.INTERFACE.MODEL.SIGNATURE;
using System;

namespace HORTICOMMAND.DOMAIN.MODEL
{
    public class Client
    {
        public Client() { }

        public Client(IClientCommandSignature signature)
        {
            IdClient = signature.Id.GetValueOrDefault();
            DsClient = signature.Client;
            DsEmail = signature.Email;
            DsPhone = signature.Phone;
            IdCity = signature.City;
            IdDistrict = signature.District;
            DsFederalInscription = signature.FederalInscription;
        }

        public Guid IdClient { get; set; }
        public string DsEmail { get; set; }
        public string DsClient { get; set; }
        public int? IdCity { get; set; }
        public Guid? IdDistrict { get; set; }
        public string DsPhone { get; set; }
        public string DsFederalInscription { get; set; }
        public string DsZip { get; set; }
        public string DsAddress { get; set; }
        public string DsNumber { get; set; }
        public string DsComplement { get; set; }

        public EmailObject EmailObject => new EmailObject(DsEmail);
        public PhoneObject PhoneObject => new PhoneObject(DsPhone);
        public DocumentObject FederalDocument => new DocumentObject(DsFederalInscription);

        public virtual City IdCityNavigation { get; set; }
        public virtual District IdDistrictNavigation { get; set; }
    }
}
