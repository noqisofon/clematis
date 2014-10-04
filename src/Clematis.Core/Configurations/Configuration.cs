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

using Clematis.Infrastructure.Caching;
using Clematis.Infrastructure.Mapping;


namespace Clematis.Configurations {


    /// <summary>
    /// 
    /// </summary>
    public class Configuration {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clematis.Configurations.Configuration"/> class.
        /// </summary>
        public Configuration() {}
        /// <summary>
        /// Initializes a new instance of the <see cref="Clematis.Configurations.Configuration"/> class.
        /// </summary>
        /// <param name="surrounding">Surrounding.</param>
        public Configuration(Surrounding surrounding) {
            this.surrounding_ = surrounding;
        }


        public AutoMappingBehavior AutoMappingBehavior {
            get { return this.auto_mapping_behavior_; }
            set { this.auto_mapping_behavior_ = value; }
        }
        public IEnumerable<ICache> Caches {
            get { return this.caches_.Values; }
        }
        /// <summary>
        /// Gets or sets the database identifier.
        /// </summary>
        /// <value>The database identifier.</value>
        public string DatabaseId {
            get { return this.database_id_; }
            set { this.database_id_ = value; }
        }
        /// <summary>
        /// Gets or sets the surrounding.
        /// </summary>
        /// <value>The surrounding.</value>
        public Surrounding Surrounding {
            get { return this.surrounding_; }
            set { this.surrounding_ = value; }
        }


        /// <summary>
        /// Adds the cache.
        /// </summary>
        /// <returns>The cache.</returns>
        /// <param name="cache">Cache.</param>
        public void AddCache(ICache cache) {
            this.caches_.Add( cache.Id, cache );
        }


        /// <summary>
        /// Adds the cache reference.
        /// </summary>
        /// <returns>The cache reference.</returns>
        /// <param name="namespace">Namespace.</param>
        /// <param name="referenced_namespace">Referenced_namespace.</param>
        public void AddCacheRef(string @namespace, string referenced_namespace) {
            this.caches_ref_map_.Add( @namespace, referenced_namespace );
        }


        /// <summary>
        /// Gets the cache.
        /// </summary>
        /// <returns>The cache.</returns>
        /// <param name="id">Identifier.</param>
        public ICache GetCache(string id) {
            if ( !this.caches_.ContainsKey( id ) ) {
            }
            return this.caches_[id];
        }


        /// <summary>
        /// The surrounding_.
        /// </summary>
        private Surrounding surrounding_;
        /// <summary>
        /// The database_id_.
        /// </summary>
        private string database_id_;
        /// <summary>
        /// The caches_.
        /// </summary>
        private IDictionary<string, ICache> caches_;
        /// <summary>
        /// The caches_ref_map_.
        /// </summary>
        private IDictionary<string, string> caches_ref_map_;
    }
}
