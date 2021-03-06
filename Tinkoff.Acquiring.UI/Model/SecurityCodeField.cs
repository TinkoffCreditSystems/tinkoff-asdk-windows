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
using System.Linq;

namespace Tinkoff.Acquiring.UI.Model
{
    class SecurityCodeField : ICardModelField
    {
        #region Fields

        private State state = State.PartiallyValid;
        private string data = string.Empty;

        #endregion

        #region Properties

        public bool IsReadOnly { get; } = false;

        public bool IsValid => state == State.Valid;

        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                if (Validate(value))
                {
                    data = value;
                }
            }
        }

        public string FormattedData => Data;

        #endregion

        #region 

        private bool Validate(string s)
        {
            if (s == null) return false;
            if (s.All(Char.IsDigit))
            {
                state = s.Length == 3 ? State.Valid : State.PartiallyValid;
                return true;
            }
            return false;
        }

        #endregion

    }
}