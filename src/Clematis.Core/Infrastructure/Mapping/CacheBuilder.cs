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

using Clematis.Infrastructure.Caching;


namespace Clematis.Infrastructure.Mapping {


    /// <summary>
    /// Cache builder.
    /// </summary>
    public class CacheBuilder {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clematis.Infrastructure.Mapping.CacheBuilder"/> class.
        /// </summary>
        public CacheBuilder(string id) {
            this.id_ = id;
        }


        /// <summary>
        /// Adds the decorator.
        /// </summary>
        /// <returns>The decorator.</returns>
        /// <param name="decorator">Decorator.</param>
        /// <typeparam name="_Type">The 1st type parameter.</typeparam>
        public CacheBuilder AddDecorator<_Type>(_Type decorator) where _Type : class, ICache {
            this.decorators_.Add( decorator.Id, decorator );

            return this;
        }


        /// <summary>
        /// Build this instance.
        /// </summary>
        public ICache Build() {
            return null;
        }


        /// <summary>
        /// Clears the interval.
        /// </summary>
        /// <returns>The interval.</returns>
        /// <param name="clear_interval">Clear_interval.</param>
        public CacheBuilder ClearInterval(long clear_interval) {
            this.clear_interval_ = clear_interval;

            return this;
        }


        /// <summary>
        /// The id_.
        /// </summary>
        private string id_;
        /// <summary>
        /// The decorators_.
        /// </summary>
        private IDictionary<string, ICache> decorators_;
        /// <summary>
        /// The clear_interval_.
        /// </summary>
        private long clear_interval_;
    }
}

