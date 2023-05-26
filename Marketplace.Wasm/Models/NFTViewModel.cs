﻿using System;
using System.Numerics;
using Marketplace.Shared;

namespace Marketplace.Wasm.Models
{
	public class NFTViewModel
	{
        public BigInteger Price { get; set; }
        public BigInteger TokenId { get; set; }
        public BigInteger QuantityForSale { get; set; }
        public bool ForSale { get; set; }
        public string Minter { get; set; }

        public TokenMetadata TokenMetadata { get; set; }
    }
}

