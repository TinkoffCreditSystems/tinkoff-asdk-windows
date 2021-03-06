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

namespace Tinkoff.Acquiring.Sdk
{
    /// <summary>
    /// RawData class.
    /// </summary>
    class RawData
    {
        #region Ctor

        /// <summary>
        /// Инициализирует новый экземпляр класса RawData.
        /// </summary>
        /// <param name="value">Необработанные данные.</param>
        public RawData(string value)
        {
            Value = value;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Возвращает необработанные данные.
        /// </summary>
        public string Value { get; private set; }

        #endregion

        #region Public Members

        /// <summary>
        /// Десериализует необработанные данные в указанный тип.
        /// </summary>
        /// <typeparam name="T">Тип, в который требуетя десериализовать необработанные данные.</typeparam>
        /// <returns>Объект типа T.</returns>
        public T To<T>()
        {
            return Serializer.To<T>(Value);
        }

        #endregion
    }
}
