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
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Clematis.Infrastructure.Mapping {


    /// <summary>
    /// 
    /// </summary>
    public class ResultMap {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public ResultMap(string id) {
            this.id_ = id;
            this.auto_mapping_ = false;
            this.constructor_result_mappings_ = new List<ResultMapping>();
        }


        /// <summary>
        /// Gets the auto mapping.
        /// </summary>
        /// <value>The auto mapping.</value>
        public bool AutoMapping {
            get { return this.auto_mapping_; }
        }
        /// <summary>
        /// Gets the constructor result mappings.
        /// </summary>
        /// <value>The constructor result mappings.</value>
        public IEnumerable<ResultMapping> ConstructorResultMappings {
            get { return this.constructor_result_mappings_; }
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id {
            get { return this.id_; }
        }


        /// <summary>
        /// Forces the nested result maps.
        /// </summary>
        /// <returns>The nested result maps.</returns>
        public void ForceNestedResultMaps() {
        }


        /// <summary>
        /// The auto_mapping_.
        /// </summary>
        private bool auto_mapping_;
        /// <summary>
        /// The constructor_result_mappings_.
        /// </summary>
        private IList<ResultMapping> constructor_result_mappings_;
        /// <summary>
        /// The id_.
        /// </summary>
        private string id_;
    }
}
