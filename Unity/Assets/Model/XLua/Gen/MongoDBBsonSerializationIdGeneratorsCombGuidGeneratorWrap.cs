﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class MongoDBBsonSerializationIdGeneratorsCombGuidGeneratorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GenerateId", _m_GenerateId);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsEmpty", _m_IsEmpty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "NewCombGuid", _m_NewCombGuid);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator gen_ret = new MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator gen_to_be_invoked = (MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _container = translator.GetObject(L, 2, typeof(object));
                    object _document = translator.GetObject(L, 3, typeof(object));
                    
                        object gen_ret = gen_to_be_invoked.GenerateId( _container, _document );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsEmpty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator gen_to_be_invoked = (MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _id = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.IsEmpty( _id );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewCombGuid(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator gen_to_be_invoked = (MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Guid _guid;translator.Get(L, 2, out _guid);
                    System.DateTime _timestamp;translator.Get(L, 3, out _timestamp);
                    
                        System.Guid gen_ret = gen_to_be_invoked.NewCombGuid( _guid, _timestamp );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.IdGenerators.CombGuidGenerator.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
