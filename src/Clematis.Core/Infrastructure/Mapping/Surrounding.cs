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
using Clematis.Transaction;



namespace Clematis.Infrastructure.Mapping {


    /// <summary>
    /// Surrounding.
    /// </summary>
    public class Surrounding {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clematis.Infrastructure.Mapping.Surrounding"/> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="transaction_factory">Transaction_factory.</param>
        /// <param name="data_source">Data_source.</param>
        public Surrounding(string id, TransactionFactory transaction_factory, IDataSource data_source) {
            this.id_ = id;
            this.transaction_factory_ = transaction_factory;
            this.data_source_ = data_source;
        }


        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id {
            get { return this.id_; }
        }
        /// <summary>
        /// Gets the data source.
        /// </summary>
        /// <value>The data source.</value>
        public IDataSource DataSource {
            get { return this.data_source_; }
        }
        /// <summary>
        /// Gets the transaction factory.
        /// </summary>
        /// <value>The transaction factory.</value>
        public TransactionFactory TransactionFactory {
            get { return this.transaction_factory_; }
        }


        /// <summary>
        /// The id_.
        /// </summary>
        private string id_;
        /// <summary>
        /// The transaction_factory_.
        /// </summary>
        private TransactionFactory transaction_factory_;
        /// <summary>
        /// The data_source_.
        /// </summary>
        private IDataSource data_source_;
    }
}

