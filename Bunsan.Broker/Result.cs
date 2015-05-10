﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunsan.Broker
{
    [ProtoContract]
    public enum ResultStatus
    {
        [ProtoEnum]
        OK = 0,
        [ProtoEnum]
        ERROR = 1,

        // proto errors
        [ProtoEnum]
        PROTO_ERROR = 100,

        // worker errors
        [ProtoEnum]
        WORKER_ERROR = 200,
        
        // package errors
        [ProtoEnum]
        PACKAGE_ERROR = 300,
        [ProtoEnum]
        PACKAGE_NOT_FOUND = 301,
        [ProtoEnum]
        PACKAGE_BUILD_ERROR = 302,

        // execution errors
        [ProtoEnum]
        EXECUTION_ERROR = 400,
        [ProtoEnum]
        EXECUTION_TIMEOUT = 401,
    }

    [ProtoContract]
    public class Result
    {
        [ProtoMember(1, IsRequired = false)]
        public ResultStatus Status { get; set; }

        [ProtoMember(2, IsRequired = false)]
        public string Reason { get; set; }

        [ProtoMember(3, IsRequired = false)]
        public byte[] Data { get; set; }
    }
}
