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
using Clematis.Infrastructure.Sessions;


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


        /// <summary>
        /// Gets or sets the auto mapping behavior.
        /// </summary>
        /// <value>The auto mapping behavior.</value>
        public AutoMappingBehavior AutoMappingBehavior {
            get { return this.auto_mapping_behavior_; }
            set { this.auto_mapping_behavior_ = value; }
        }
        /// <summary>
        /// Gets the caches.
        /// </summary>
        /// <value>The caches.</value>
        public IEnumerable<ICache> Caches {
            get { return this.caches_.Values.ToArray(); }
        }
        /// <summary>
        /// Gets the cache names.
        /// </summary>
        /// <value>The cache names.</value>
        public IEnumerable<string> CacheNames {
            get { return this.caches_.Keys.ToArray(); }
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
        /// Gets the default type of the executor.
        /// </summary>
        /// <value>The default type of the executor.</value>
        public ExecutorType DefaultExecutorType {
            get { return this.default_executor_type_; }
        }
        /// <summary>
        /// Gets the default statement timeout.
        /// </summary>
        /// <value>The default statement timeout.</value>
        public int DefaultStatementTimeout {
            get { return this.default_statement_timeout_; }
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
        /// Determines whether this instance has cache the specified id.
        /// </summary>
        /// <returns><c>true</c> if this instance has cache the specified id; otherwise, <c>false</c>.</returns>
        /// <param name="id">Identifier.</param>
        public bool HasCache(string id) {
            return this.caches_.ContainsKey( id );
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
        /// Builds all statements.
        /// </summary>
        protected void BuildAllStatements() {
        }


        /// <summary>
        /// Checks the globally for discriminated nested result maps.
        /// </summary>
        /// <returns>The globally for discriminated nested result maps.</returns>
        /// <param name="result_map">Result_map.</param>
        protected void CheckGloballyForDiscriminatedNestedResultMaps(ResultMap result_map) {
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
        /// <summary>
        /// The default_executor_type_.
        /// </summary>
        private ExecutorType default_executor_type_;
        /// <summary>
        /// The default_statement_timeout_.
        /// </summary>
        private int default_statement_timeout_;
    }
}
