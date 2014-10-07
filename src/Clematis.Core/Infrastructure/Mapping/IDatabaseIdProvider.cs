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

using Clematis.Database;


namespace Clematis.Infrastructure.Mapping {


    /// <summary>
    /// I database identifier provider.
    /// </summary>
    public interface IDatabaseIdProvider {
        /// <summary>
        /// Gets the database identifier.
        /// </summary>
        /// <returns>The database identifier.</returns>
        /// <param name="data_source">Data_source.</param>
        string GetDatabaseId(IDataSource data_source);


        /// <summary>
        /// Sets the properties.
        /// </summary>
        /// <returns>The properties.</returns>
        /// <param name="properties">Properties.</param>
        void SetProperties(IDictionary<string, object> properties);
    }
}

