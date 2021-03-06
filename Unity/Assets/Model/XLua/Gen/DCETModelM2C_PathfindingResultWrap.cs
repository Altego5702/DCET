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
    public class DCETModelM2C_PathfindingResultWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.M2C_PathfindingResult);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 8, 8);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteTo", _m_WriteTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateSize", _m_CalculateSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MergeFrom", _m_MergeFrom);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ActorId", _g_get_ActorId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Id", _g_get_Id);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "X", _g_get_X);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Y", _g_get_Y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Z", _g_get_Z);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Xs", _g_get_Xs);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Ys", _g_get_Ys);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Zs", _g_get_Zs);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ActorId", _s_set_ActorId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Id", _s_set_Id);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "X", _s_set_X);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Y", _s_set_Y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Z", _s_set_Z);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Xs", _s_set_Xs);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Ys", _s_set_Ys);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Zs", _s_set_Zs);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Parser", _g_get_Parser);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					DCET.Model.M2C_PathfindingResult gen_ret = new DCET.Model.M2C_PathfindingResult();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.M2C_PathfindingResult constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Google.Protobuf.CodedOutputStream _output = (Google.Protobuf.CodedOutputStream)translator.GetObject(L, 2, typeof(Google.Protobuf.CodedOutputStream));
                    
                    gen_to_be_invoked.WriteTo( _output );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateSize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.CalculateSize(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MergeFrom(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Google.Protobuf.CodedInputStream _input = (Google.Protobuf.CodedInputStream)translator.GetObject(L, 2, typeof(Google.Protobuf.CodedInputStream));
                    
                    gen_to_be_invoked.MergeFrom( _input );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Parser(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, DCET.Model.M2C_PathfindingResult.Parser);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ActorId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.ActorId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Id(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.Id);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_X(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.X);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Y(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.Y);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Z(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.Z);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Xs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Xs);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Ys(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Ys);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Zs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Zs);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ActorId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ActorId = LuaAPI.lua_toint64(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Id(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Id = LuaAPI.lua_toint64(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_X(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.X = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Y(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Y = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Z(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Z = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Xs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Xs = (Google.Protobuf.Collections.RepeatedField<float>)translator.GetObject(L, 2, typeof(Google.Protobuf.Collections.RepeatedField<float>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Ys(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Ys = (Google.Protobuf.Collections.RepeatedField<float>)translator.GetObject(L, 2, typeof(Google.Protobuf.Collections.RepeatedField<float>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Zs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.M2C_PathfindingResult gen_to_be_invoked = (DCET.Model.M2C_PathfindingResult)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Zs = (Google.Protobuf.Collections.RepeatedField<float>)translator.GetObject(L, 2, typeof(Google.Protobuf.Collections.RepeatedField<float>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
