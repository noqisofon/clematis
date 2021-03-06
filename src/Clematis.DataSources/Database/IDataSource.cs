﻿//
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
using System.IO;


namespace Clematis.Database {


    /// <summary>
    /// I data source.
    /// </summary>
    public interface IDataSource {
        /// <summary>
        /// Gets or sets the login timeout.
        /// </summary>
        /// <value>The login timeout.</value>
        int LoginTimeout { get; set; }
        /// <summary>
        /// Gets or sets the log writer.
        /// </summary>
        /// <value>The log writer.</value>
        TextWriter LogWriter { get; set; }


        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>The connection.</returns>
        ISqlConnection GetConnection();
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>The connection.</returns>
        /// <param name="user_name">User_name.</param>
        /// <param name="password">Password.</param>
        ISqlConnection GetConnection(string user_name, string password);
    }
}

