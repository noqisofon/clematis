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

using Clematis.Configurations;
using Clematis.Infrastructure.Executors;
using Clematis.Infrastructure.Sessions;


namespace Clematis.Infrastructure {


    /// <summary>
    /// I sql session.
    /// </summary>
    public interface ISqlSession {
        /// <summary>
        /// Clears the cache.
        /// </summary>
        /// <returns>The cache.</returns>
        void ClearCache();


        /// <summary>
        /// Close this instance.
        /// </summary>
        void Close();


        /// <summary>
        /// Commit this instance.
        /// </summary>
        void Commit();
        /// <summary>
        /// Commit the specified fource.
        /// </summary>
        /// <param name="fource">Fource.</param>
        void Commit(bool fource);


        /// <summary>
        /// Delete the specified statement.
        /// </summary>
        /// <param name="statement">Statement.</param>
        int Delete(string statement);
        /// <summary>
        /// Delete the specified statement and parameter.
        /// </summary>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        int Delete(string statement, object parameter);


        /// <summary>
        /// Flushs the statements.
        /// </summary>
        /// <returns>The statements.</returns>
        IEnumerable<BatchResult> FlushStatements();


        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <returns>The configuration.</returns>
        Configuration GetConfiguration();


        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>The connection.</returns>
        ISqlConnection GetConnection();


        /// <summary>
        /// Gets the mapper.
        /// </summary>
        /// <returns>The mapper.</returns>
        /// <typeparam name="_Type">The 1st type parameter.</typeparam>
        _Type GetMapper<_Type>();


        /// <summary>
        /// Insert the specified statement.
        /// </summary>
        /// <param name="statement">Statement.</param>
        int Insert(string statement);
        /// <summary>
        /// Insert the specified statement and parameter.
        /// </summary>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        int Insert(string statement, object parameter);


        /// <summary>
        /// Rollback this instance.
        /// </summary>
        void Rollback();
        /// <summary>
        /// Rollback the specified force.
        /// </summary>
        /// <param name="force">Force.</param>
        void Rollback(bool force);


        /// <summary>
        /// Select the specified statement and handler.
        /// </summary>
        /// <param name="statement">Statement.</param>
        /// <param name="handler">Handler.</param>
        void Select(string statement, ResultHandler handler);
        /// <summary>
        /// Select the specified statement, parameter and handler.
        /// </summary>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        /// <param name="handler">Handler.</param>
        void Select(string statement, object parameter, ResultHandler handler);
        /// <summary>
        /// Select the specified statement, parameter, row_bounds and handler.
        /// </summary>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        /// <param name="row_bounds">Row_bounds.</param>
        /// <param name="handler">Handler.</param>
        void Select(string statement, object parameter, RowBounds row_bounds, ResultHandler handler);


        /// <summary>
        /// Selects the list.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="statement">Statement.</param>
        /// <typeparam name="_Element">The 1st type parameter.</typeparam>
        IEnumerable<_Element> SelectList<_Element>(string statement);
        /// <summary>
        /// Selects the list.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        /// <typeparam name="_Element">The 1st type parameter.</typeparam>
        IEnumerable<_Element> SelectList<_Element>(string statement, object parameter);
        /// <summary>
        /// Selects the list.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        /// <param name="row_bounds">Row_bounds.</param>
        /// <typeparam name="_Element">The 1st type parameter.</typeparam>
        IEnumerable<_Element> SelectList<_Element>(string statement, object parameter, RowBounds row_bounds);


        /// <summary>
        /// Selects the map.
        /// </summary>
        /// <returns>The map.</returns>
        /// <param name="statement">Statement.</param>
        /// <param name="map_key">Map_key.</param>
        /// <typeparam name="_Key">The 1st type parameter.</typeparam>
        /// <typeparam name="_Value">The 2nd type parameter.</typeparam>
        IDictionary<_Key, _Value> SelectMap<_Key, _Value>(string statement, string map_key);
        /// <summary>
        /// Selects the map.
        /// </summary>
        /// <returns>The map.</returns>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        /// <param name="map_key">Map_key.</param>
        /// <typeparam name="_Key">The 1st type parameter.</typeparam>
        /// <typeparam name="_Value">The 2nd type parameter.</typeparam>
        IDictionary<_Key, _Value> SelectMap<_Key, _Value>(string statement, object parameter, string map_key);
        /// <summary>
        /// Selects the map.
        /// </summary>
        /// <returns>The map.</returns>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        /// <param name="map_key">Map_key.</param>
        /// <param name="row_bounds">Row_bounds.</param>
        /// <typeparam name="_Key">The 1st type parameter.</typeparam>
        /// <typeparam name="_Value">The 2nd type parameter.</typeparam>
        IDictionary<_Key, _Value> SelectMap<_Key, _Value>(string statement, object parameter, string map_key, RowBounds row_bounds);


        /// <summary>
        /// Selects the one.
        /// </summary>
        /// <returns>The one.</returns>
        /// <param name="statement">Statement.</param>
        /// <typeparam name="_Type">The 1st type parameter.</typeparam>
        _Type SelectOne<_Type>(string statement);
        /// <summary>
        /// Selects the one.
        /// </summary>
        /// <returns>The one.</returns>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        /// <typeparam name="_Type">The 1st type parameter.</typeparam>
        _Type SelectOne<_Type>(string statement, object parameter);


        /// <summary>
        /// Update the specified statement.
        /// </summary>
        /// <param name="statement">Statement.</param>
        int Update(string statement);
        /// <summary>
        /// Update the specified statement and parameter.
        /// </summary>
        /// <param name="statement">Statement.</param>
        /// <param name="parameter">Parameter.</param>
        int Update(string statement, object parameter);
    }


    /// <summary>
    /// Result handler.
    /// </summary>
    public delegate void ResultHandler(ResultContext context);
}
