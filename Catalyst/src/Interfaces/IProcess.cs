﻿using MessagePack;
using Mosaik.Core;
using System.IO;
using System.Threading.Tasks;

namespace Catalyst
{
    public interface IProcess : IModel
    {
        void Process(IDocument document);
    }
}