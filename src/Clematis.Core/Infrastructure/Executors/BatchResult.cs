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
using System.Collections.Generic;
using System.Linq;

using Clematis.Infrastructure.Mapping;


namespace Clematis.Infrastructure.Executors {


    /// <summary>
    /// Batch result.
    /// </summary>
    public class BatchResult {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResult"/> class.
        /// </summary>
        /// <param name="mapped_statement">Mapped_statement.</param>
        /// <param name="sql_query">Sql_query.</param>
        public BatchResult(MappedStatement mapped_statement, string sql_query) {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResult"/> class.
        /// </summary>
        /// <param name="mapped_statement">Mapped_statement.</param>
        /// <param name="sql_query">Sql_query.</param>
        /// <param name="paramenter_object">Paramenter_object.</param>
        public BatchResult(MappedStatement mapped_statement, string sql_query, object paramenter_object) {
        }


        /// <summary>
        /// Gets the mapped statement.
        /// </summary>
        /// <value>The mapped statement.</value>
        public MappedStatement MappedStatement {
            get { return this.mapped_statement_; }
        } 
        /// <summary>
        /// Gets the parameter objects.
        /// </summary>
        /// <value>The parameter objects.</value>
        public IEnumerable<object> ParameterObjects {
            get { return this.parameters_.ToArray(); }
        }


        /// <summary>
        /// Adds the parameter object.
        /// </summary>
        /// <returns>The parameter object.</returns>
        /// <param name="paramter_object">Paramter_object.</param>
        public void AddParameterObject(object paramter_object) {
        }


        /// <summary>
        /// The mapped_statement_.
        /// </summary>
        private MappedStatement mapped_statement_;
        /// <summary>
        /// The parameters_.
        /// </summary>
        private IList<object> parameters_;
    }
}

