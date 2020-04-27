using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets.Delivery
{
    //Since the track it´s mutable I decided to use class
    class DeliveryLogistics
    {
        private DateTime _registerDate;
        private int _custmerNif;
        private DateTime _deliveryDate;
        private DateTime _arrivalEstimate;

        public DateTime registerDate
        {
            get
            {
                return _registerDate;
            }
        }
        public int custumerNif
        {
            get
            {
                return _custmerNif;
            }
        }
        public DateTime deliveryDate
        {
            get
            {
                return _deliveryDate;
            }
        }
        public DateTime arrivalEstimate
        {
            get
            {
                return _arrivalEstimate;
            }
        }

        public DeliveryLogistics(DateTime registerDate, int custumerNif, DateTime deliveryDate)
        {
            registerDate = _registerDate;
            custumerNif = _custmerNif;
            deliveryDate = _deliveryDate;

            _arrivalEstimate = registerDate.AddDays(5);

        }
    }
}
