// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PetStore.Service.Models
{

    ///<summary>
    /// Resource create or update operation model.
    ///</summary>
    public partial class InsuranceUpdate
    {
        public string Provider { get; set; }

        public int? Premium { get; set; }

        public int? Deductible { get; set; }


    }
}
