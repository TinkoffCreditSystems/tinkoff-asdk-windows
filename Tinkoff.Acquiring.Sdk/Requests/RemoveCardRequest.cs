﻿#region License

// Copyright © 2016 Tinkoff Bank
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//  
//     http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System.Collections.Generic;

namespace Tinkoff.Acquiring.Sdk.Requests
{
    /// <summary>
    /// Удаляет привязанную карту.
    /// </summary>
    sealed class RemoveCardRequest : AcquiringRequest
    {
        /// <summary>
        /// Вовзвращает имя опреации.
        /// </summary>
        public override string Operation => "RemoveCard";

        /// <summary>
        /// Возвращает идентификатор карты в системе Банка.
        /// </summary>
        public string CardId { get; set; }

        /// <summary>
        /// Возвращает идентификатор покупателя в системе Продавца.
        /// </summary>
        public string CustomerKey { get; set; }

        #region Methods

        public override IDictionary<string, string> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            if (!string.IsNullOrEmpty(CardId))
                dictionary.Add(Fields.CARDID, CardId);
            if (!string.IsNullOrEmpty(CustomerKey))
                dictionary.Add(Fields.CUSTOMERKEY, CustomerKey);
            return dictionary;
        }

        #endregion
    }
}
