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


namespace Clematis.Database {


    /// <summary>
    /// 
    /// </summary>
    public interface ISqlConnection {
        /// <summary>
        /// Gets the auto commit.
        /// </summary>
        /// <value>The auto commit.</value>
        bool AutoCommit { get; set; }
        /// <summary>
        /// Gets the catalog.
        /// </summary>
        /// <value>The catalog.</value>
        string Catalog { get; set; }
        /// <summary>
        /// Gets the holdability.
        /// </summary>
        /// <value>The holdability.</value>
        int Holdability { get; set; }
        /// <summary>
        /// Gets the meta data.
        /// </summary>
        /// <value>The meta data.</value>
        DatabaseMetaData MetaData { get; }


        /// <summary>
        /// Clears the warnings.
        /// </summary>
        /// <returns>The warnings.</returns>
        void ClearWarnings();


        /// <summary>
        /// Close this instance.
        /// </summary>
        void Close();


        /// <summary>
        /// Commit this instance.
        /// </summary>
        void Commit();


        /// <summary>
        /// Creates the statement.
        /// </summary>
        /// <returns>The statement.</returns>
        ISqlStatement CreateStatement();
        /// <summary>
        /// Creates the statement.
        /// </summary>
        /// <returns>The statement.</returns>
        /// <param name="result_set_type">Result_set_type.</param>
        /// <param name="result_set_concurrency">Result_set_concurrency.</param>
        ISqlStatement CreateStatement(int result_set_type, int result_set_concurrency);
        /// <summary>
        /// Creates the statement.
        /// </summary>
        /// <returns>The statement.</returns>
        /// <param name="result_set_type">Result_set_type.</param>
        /// <param name="result_set_concurrency">Result_set_concurrency.</param>
        /// <param name="result_set_foldability">Result_set_foldability.</param>
        ISqlStatement CreateStatement(int result_set_type, int result_set_concurrency, int result_set_foldability);
    }
}