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

using Clematis.Infrastructure.Sessions;


namespace Clematis.Infrastructure.Mapping {


    /// <summary>
    /// Bound sql.
    /// </summary>
    public class BoundSql {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clematis.Infrastructure.Mapping.BoundSql"/> class.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        /// <param name="sql_query">Sql_query.</param>
        /// <param name="parameter_mappings">Parameter_mapping.</param>
        /// <param name="parameter_object">Parameter_object.</param>
        public BoundSql(Configuration configuration, string sql_query, IEnumerable<ParameterMapping> parameter_mappings, object parameter_object) {
            this.configuration_     = configuration;
            this.sql_query_         = sql_query;
            if ( parameter_mapping == null ) {
                this.parameter_mappings_ = new List<ParameterMapping>();
            } else {
                this.parameter_mappings_ = parameter_mappings.ToList();
            }
            this.parameter_object_  = parameter_object;
            this.additional_parameter_ = new Dictionary<string, object>();
        }


        /// <summary>
        /// Gets the parameter object.
        /// </summary>
        /// <value>The parameter object.</value>
        public object ParameterObject {
            get { return this.parameter_object_; }
        }
        /// <summary>
        /// Gets the additional parameter.
        /// </summary>
        /// <returns>The additional parameter.</returns>
        /// <param name="name">Name.</param>
        public IEnumerable<ParameterMapping> ParameterMappings {
            get { return this.parameter_mappings_; }
        }


        /// <summary>
        /// Gets the additional parameter.
        /// </summary>
        /// <returns>The additional parameter.</returns>
        /// <param name="name">Name.</param>
        public object GetAdditionalParameter(string name) {
            return this.additional_parameter_[name];
        }


        /// <summary>
        /// Sets the additional parameter.
        /// </summary>
        /// <returns>The additional parameter.</returns>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        public void SetAdditionalParameter(string name, object value) {
            this.additional_parameter_[name] = value;
        }


        /// <summary>
        /// Determines whether this instance has additional parameter the specified name.
        /// </summary>
        /// <returns><c>true</c> if this instance has additional parameter the specified name; otherwise, <c>false</c>.</returns>
        /// <param name="name">Name.</param>
        public bool HasAdditionalParameter(string name) {
            return this.additional_parameter_.ContainsKey( name );
        }


        /// <summary>
        /// The configuration_.
        /// </summary>
        private Configuration configuration_;
        /// <summary>
        /// The sql_query_.
        /// </summary>
        private string sql_query_;
        /// <summary>
        /// The parameter_mapping_.
        /// </summary>
        private IList<ParameterMapping> parameter_mappings_;
        /// <summary>
        /// The additional_parameter_.
        /// </summary>
        private IDictionary<string, object> additional_parameter_;
    }
}

