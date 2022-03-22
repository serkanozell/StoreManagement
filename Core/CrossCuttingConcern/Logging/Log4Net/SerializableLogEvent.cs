﻿using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcern.Logging.Log4Net
{
    [Serializable]
    public class SerializableLogEvent
    {
        LoggingEvent _loggingEvent;

        public SerializableLogEvent(LoggingEvent loggingEvent)
        {
            _loggingEvent = loggingEvent;
        }


        public object Message => _loggingEvent.MessageObject;

        //public object Message() yukarıdakinin metot hali!!
        //{
        //    return _loggingEvent.MessageObject;
        //}
    }
}
