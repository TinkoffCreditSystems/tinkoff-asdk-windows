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
    /// Хранит данные, необходимые для прохождения 3DS.
    /// </summary>
    public class ThreeDsData
    {
        /// <summary>
        /// Возвращает Access Control Server Url
        /// </summary>
        public string ACSUrl { get; internal set; }

        /// <summary>
        /// Возвращает данные продавца.
        /// </summary>
        public string MD { get; internal set; }

        /// <summary>
        /// Возвращает запрос на аутентификацию плательщика.
        /// </summary>
        public string PaReq { get; internal set; }

        /// <summary>
        /// Возвращает флаг, требует ли терминал прохождения 3DS.
        /// </summary>
        public bool IsThreeDsNeed { get; internal set; }
    }
}