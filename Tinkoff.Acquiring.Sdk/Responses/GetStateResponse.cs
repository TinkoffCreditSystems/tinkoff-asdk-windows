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

using System;
using System.Runtime.Serialization;

namespace Tinkoff.Acquiring.Sdk.Responses
{
    /// <summary>
    /// Ответ на запрос статуса платежа.
    /// </summary>
    [DataContract]
    sealed class GetStateResponse : AcquiringResponse
    {
        #region Fields

        [DataMember(Name = "Status")]
        private string status;

        #endregion

        #region Properties

        /// <summary>
        /// Возвращает номер заказа в системе Продавца.
        /// </summary>
        [DataMember]
        public string OrderId { get; internal set; }

        /// <summary>
        /// Возвращает статус транзакции.
        /// </summary>
        [IgnoreDataMember]
        public PaymentStatus Status { get; internal set; }

        /// <summary>
        /// Возвращает уникальный идентификатор транзакции в системе Банка.
        /// </summary>
        [DataMember]
        public string PaymentId { get; internal set; }

        #endregion

        #region Internal Members

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            if (status == "3DS_CHECKING")
            {
                Status = PaymentStatus.DS_CHECKING;
                return;
            }
            if (status == "3DS_CHECKED")
            {
                Status = PaymentStatus.DS_CHECKED;
                return;
            }
            PaymentStatus value;
            Enum.TryParse(status, out value);
            Status = value;
        }

        #endregion
    }
}
