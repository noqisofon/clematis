//
//  Copyright 2014  ned rihine
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
using System;


namespace Clematis.Infrastructure.Mapping {


    /// <summary>
    /// Parameter mapping.
    /// </summary>
    public class ParameterMapping {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clematis.Infrastructure.Mapping.ParameterMapping"/> class.
        /// </summary>
        protected ParameterMapping() {
        }


        /// <summary>
        /// Gets or sets the type of the clr.
        /// </summary>
        /// <value>The type of the clr.</value>
        public Type ClrType { get; internal set; }
        /// <summary>
        /// Gets or sets the type of the sql.
        /// </summary>
        /// <value>The type of the sql.</value>
        public SqlType SqlType { get; internal set; }
        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>The mode.</value>
        public ParameterMode Mode { get; internal set; }
    }
}

