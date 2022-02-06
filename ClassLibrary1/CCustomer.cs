using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    /// <summary>
    ///     New release Customer class
    /// </summary>
    public class CCustomer
    {
        /// <summary>
		/// Initializes a new instance of the <see cref="CCustomer"/>  class.
		/// </summary>
		/// <param><c>name</c> is the customer name.
		/// </param>
        public CCustomer(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets the customer name.  
        /// </summary>
        /// <example>For example:
        /// <code>
        /// CCustomer customer new CCustomer("James") { BonusPonts=25}
        /// string name = customer.Name;
        /// </code>
        /// results in <c>name</c>'s having the value "James".
        /// </example>
        /// <value>The customer name.</value>
        public string Name { get; set; }


        /// <summary>
		/// Gets the bonus points from a customer.  
		/// </summary>
		/// <example>For example:
		/// <code>
		/// CCustomer customer new CCustomer("James") { BonusPonts=25}
		/// int bonusPoints = customer.BonusPonts;
		/// </code>
		/// results in <c>bonusPoints</c>'s having the value 25.
		/// </example>
		/// <value>The bonus points from a customer.</value>
        public int BonusPonts { get; set; }

        /// <summary>The customer name.</summary>
        /// <returns>The customer name</returns>
        public override string ToString()
        {
            return  Name ;
        }
        
    }
}
