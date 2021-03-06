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

using System.Runtime.Serialization;

namespace Tinkoff.Acquiring.Sample.Models
{
    [DataContract]
    public class VolumeInfo
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "authors")]
        public string[] Authors { get; set; }

        [DataMember(Name = "publisher")]
        public string Publisher { get; set; }

        [DataMember(Name = "publishedDate")]
        public string PublishedDate { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "imageLinks")]
        public ImageLinks ImageLinks { get; set; }
    }
}
