














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Fold : ReqlExpr {

    
    
    
        public Fold (object arg) : this(new Arguments(arg), null) {
        }
        public Fold (Arguments args) : this(args, null) {
        }
        public Fold (Arguments args, OptArgs optargs)
         : base(TermType.FOLD, args, optargs) {
        }


    



    
///<summary>
/// "emit": "T_FUNC3",
///  "final_emit": "T_FUNC1"
///</summary>
        public Fold this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Fold (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "emit": "T_FUNC3",
///  "final_emit": "T_FUNC1"
///</summary>
    public Fold this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Fold (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "emit": "T_FUNC3",
///  "final_emit": "T_FUNC1"
///</summary>
        public Fold optArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Fold (this.Args, newOptArgs);
        }


    

    
        /// <summary>
        /// Get a single field from an object. If called on a sequence, gets that field from every object in the sequence, skipping objects that lack it.
        /// </summary>
        /// <param name="bracket"></param>
        public new Bracket this[string bracket] => base[bracket];
        
        /// <summary>
        /// Get the nth element of a sequence, counting from zero. If the argument is negative, count from the last element.
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public new Bracket this[int bracket] => base[bracket];


    

    


    
    }
}
