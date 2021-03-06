
//------------------------------------------------------------------------------    
// <auto-generated>                                                                 
//     This code was generated by Tools.MacroExpansion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null. 
//     https://github.com/JiepengTan/LockstepEngine                                          
//     Changes to this file may cause incorrect behavior and will be lost if        
//     the code is regenerated.                                                     
// </auto-generated>                                                                
//------------------------------------------------------------------------------  

//Power by ME //src: https://github.com/JiepengTan/ME  

//#define DONT_USE_GENERATE_CODE                                                                 
                                                                                                 
using System.Linq;                                                                               
using Lockstep.Serialization;                                                                    
using System.Runtime.InteropServices;                                                            
using System.Runtime.CompilerServices;                                                            
using System;                                                                                    
using Lockstep.InternalUnsafeECS;                                                               
using System.Collections;                                                                        
using Lockstep.Math;                                                                             
using System.Collections.Generic;                                                                
using Lockstep.Logging;                                                                          
using Lockstep.Util;                                                                          
namespace Lockstep.UnsafeECS.Game {  

    [StructLayout(LayoutKind.Sequential, Pack = Define.PackSize)]
    public unsafe partial class _EntityManager :InternalBaseEntityManager{

#region Size Offset of Entity Field
        private NativeArray<T> _GetAllPlayerCube_Transform3D<T>(int compFieldOffset,FuncEntityFilter<Entity> filterFunc,out int length) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Transform() + compFieldOffset,filterFunc,out length);}
        private NativeArray<T> _GetAllPlayerCube_Transform3D<T>(int compFieldOffset) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Transform()+ compFieldOffset);}
        private NativeArray<Transform3D> _GetAllPlayerCube_Transform(){return _GetAllEntityField<Transform3D,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Transform());} 
        private int _GetOffsetOfPlayerCube_Transform(){ var tempObj =  new PlayerCube(); PlayerCube* ptr = &tempObj;var filedPtr = &(ptr->Transform);  return (int)((long) filedPtr - (long) ptr);        }
        private NativeArray<T> _GetAllPlayerCube_Prefab<T>(int compFieldOffset,FuncEntityFilter<Entity> filterFunc,out int length) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Prefab() + compFieldOffset,filterFunc,out length);}
        private NativeArray<T> _GetAllPlayerCube_Prefab<T>(int compFieldOffset) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Prefab()+ compFieldOffset);}
        private NativeArray<Prefab> _GetAllPlayerCube_Prefab(){return _GetAllEntityField<Prefab,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Prefab());} 
        private int _GetOffsetOfPlayerCube_Prefab(){ var tempObj =  new PlayerCube(); PlayerCube* ptr = &tempObj;var filedPtr = &(ptr->Prefab);  return (int)((long) filedPtr - (long) ptr);        }
        private NativeArray<T> _GetAllPlayerCube_MoveData<T>(int compFieldOffset,FuncEntityFilter<Entity> filterFunc,out int length) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Move() + compFieldOffset,filterFunc,out length);}
        private NativeArray<T> _GetAllPlayerCube_MoveData<T>(int compFieldOffset) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Move()+ compFieldOffset);}
        private NativeArray<MoveData> _GetAllPlayerCube_Move(){return _GetAllEntityField<MoveData,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Move());} 
        private int _GetOffsetOfPlayerCube_Move(){ var tempObj =  new PlayerCube(); PlayerCube* ptr = &tempObj;var filedPtr = &(ptr->Move);  return (int)((long) filedPtr - (long) ptr);        }
        private NativeArray<T> _GetAllPlayerCube_PlayerData<T>(int compFieldOffset,FuncEntityFilter<Entity> filterFunc,out int length) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Player() + compFieldOffset,filterFunc,out length);}
        private NativeArray<T> _GetAllPlayerCube_PlayerData<T>(int compFieldOffset) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Player()+ compFieldOffset);}
        private NativeArray<PlayerData> _GetAllPlayerCube_Player(){return _GetAllEntityField<PlayerData,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Player());} 
        private int _GetOffsetOfPlayerCube_Player(){ var tempObj =  new PlayerCube(); PlayerCube* ptr = &tempObj;var filedPtr = &(ptr->Player);  return (int)((long) filedPtr - (long) ptr);        }
        private NativeArray<T> _GetAllPlayerCube_PlayerCubeTag<T>(int compFieldOffset,FuncEntityFilter<Entity> filterFunc,out int length) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Tag() + compFieldOffset,filterFunc,out length);}
        private NativeArray<T> _GetAllPlayerCube_PlayerCubeTag<T>(int compFieldOffset) where T: unmanaged{return _GetAllEntityField<T,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Tag()+ compFieldOffset);}
        private NativeArray<PlayerCubeTag> _GetAllPlayerCube_Tag(){return _GetAllEntityField<PlayerCubeTag,PlayerCube>(_PlayerCubeAry,_GetOffsetOfPlayerCube_Tag());} 
        private int _GetOffsetOfPlayerCube_Tag(){ var tempObj =  new PlayerCube(); PlayerCube* ptr = &tempObj;var filedPtr = &(ptr->Tag);  return (int)((long) filedPtr - (long) ptr);        }        

        private int _GetOffsetOfAnimator_Pad(){var tempObj =  new Animator(); Animator* ptr = &tempObj; var filedPtr = &(ptr->Pad);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfAnimator_Pad(){ return sizeof(int); } 
        private int _GetOffsetOfCollisionAgent_Collider(){var tempObj =  new CollisionAgent(); CollisionAgent* ptr = &tempObj; var filedPtr = &(ptr->Collider);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfCollisionAgent_Collider(){ return sizeof(CollisionShape); }
        private int _GetOffsetOfCollisionAgent_IsTrigger(){var tempObj =  new CollisionAgent(); CollisionAgent* ptr = &tempObj; var filedPtr = &(ptr->IsTrigger);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfCollisionAgent_IsTrigger(){ return sizeof(bool); }
        private int _GetOffsetOfCollisionAgent_Layer(){var tempObj =  new CollisionAgent(); CollisionAgent* ptr = &tempObj; var filedPtr = &(ptr->Layer);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfCollisionAgent_Layer(){ return sizeof(int); }
        private int _GetOffsetOfCollisionAgent_IsEnable(){var tempObj =  new CollisionAgent(); CollisionAgent* ptr = &tempObj; var filedPtr = &(ptr->IsEnable);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfCollisionAgent_IsEnable(){ return sizeof(bool); }
        private int _GetOffsetOfCollisionAgent_IsSleep(){var tempObj =  new CollisionAgent(); CollisionAgent* ptr = &tempObj; var filedPtr = &(ptr->IsSleep);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfCollisionAgent_IsSleep(){ return sizeof(bool); }
        private int _GetOffsetOfCollisionAgent_Mass(){var tempObj =  new CollisionAgent(); CollisionAgent* ptr = &tempObj; var filedPtr = &(ptr->Mass);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfCollisionAgent_Mass(){ return sizeof(LFloat); }
        private int _GetOffsetOfCollisionAgent_AngularSpeed(){var tempObj =  new CollisionAgent(); CollisionAgent* ptr = &tempObj; var filedPtr = &(ptr->AngularSpeed);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfCollisionAgent_AngularSpeed(){ return sizeof(LFloat); }
        private int _GetOffsetOfCollisionAgent_Speed(){var tempObj =  new CollisionAgent(); CollisionAgent* ptr = &tempObj; var filedPtr = &(ptr->Speed);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfCollisionAgent_Speed(){ return sizeof(LVector3); } 
        private int _GetOffsetOfNavMeshAgent_Pad(){var tempObj =  new NavMeshAgent(); NavMeshAgent* ptr = &tempObj; var filedPtr = &(ptr->Pad);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfNavMeshAgent_Pad(){ return sizeof(int); } 
        private int _GetOffsetOfPrefab_AssetId(){var tempObj =  new Prefab(); Prefab* ptr = &tempObj; var filedPtr = &(ptr->AssetId);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfPrefab_AssetId(){ return sizeof(int); } 
        private int _GetOffsetOfTransform2D_Position(){var tempObj =  new Transform2D(); Transform2D* ptr = &tempObj; var filedPtr = &(ptr->Position);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfTransform2D_Position(){ return sizeof(LVector2); }
        private int _GetOffsetOfTransform2D_Deg(){var tempObj =  new Transform2D(); Transform2D* ptr = &tempObj; var filedPtr = &(ptr->Deg);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfTransform2D_Deg(){ return sizeof(LFloat); }
        private int _GetOffsetOfTransform2D_Scale(){var tempObj =  new Transform2D(); Transform2D* ptr = &tempObj; var filedPtr = &(ptr->Scale);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfTransform2D_Scale(){ return sizeof(LFloat); } 
        private int _GetOffsetOfTransform3D_Position(){var tempObj =  new Transform3D(); Transform3D* ptr = &tempObj; var filedPtr = &(ptr->Position);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfTransform3D_Position(){ return sizeof(LVector3); }
        private int _GetOffsetOfTransform3D_Forward(){var tempObj =  new Transform3D(); Transform3D* ptr = &tempObj; var filedPtr = &(ptr->Forward);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfTransform3D_Forward(){ return sizeof(LVector3); }
        private int _GetOffsetOfTransform3D_Scale(){var tempObj =  new Transform3D(); Transform3D* ptr = &tempObj; var filedPtr = &(ptr->Scale);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfTransform3D_Scale(){ return sizeof(LFloat); } 
        private int _GetOffsetOfPlayerCubeTag_Pad(){var tempObj =  new PlayerCubeTag(); PlayerCubeTag* ptr = &tempObj; var filedPtr = &(ptr->Pad);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfPlayerCubeTag_Pad(){ return sizeof(int); } 
        private int _GetOffsetOfAssetData_AssetId(){var tempObj =  new AssetData(); AssetData* ptr = &tempObj; var filedPtr = &(ptr->AssetId);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfAssetData_AssetId(){ return sizeof(int); } 
        private int _GetOffsetOfPlayerData_Score(){var tempObj =  new PlayerData(); PlayerData* ptr = &tempObj; var filedPtr = &(ptr->Score);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfPlayerData_Score(){ return sizeof(int); }
        private int _GetOffsetOfPlayerData_LocalId(){var tempObj =  new PlayerData(); PlayerData* ptr = &tempObj; var filedPtr = &(ptr->LocalId);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfPlayerData_LocalId(){ return sizeof(int); } 
        private int _GetOffsetOfMoveData_MoveSpd(){var tempObj =  new MoveData(); MoveData* ptr = &tempObj; var filedPtr = &(ptr->MoveSpd);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfMoveData_MoveSpd(){ return sizeof(LFloat); }
        private int _GetOffsetOfMoveData_AcceleratedSpd(){var tempObj =  new MoveData(); MoveData* ptr = &tempObj; var filedPtr = &(ptr->AcceleratedSpd);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfMoveData_AcceleratedSpd(){ return sizeof(LFloat); }
        private int _GetOffsetOfMoveData_CurSpd(){var tempObj =  new MoveData(); MoveData* ptr = &tempObj; var filedPtr = &(ptr->CurSpd);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfMoveData_CurSpd(){ return sizeof(LFloat); }
        private int _GetOffsetOfMoveData_AngularSpd(){var tempObj =  new MoveData(); MoveData* ptr = &tempObj; var filedPtr = &(ptr->AngularSpd);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfMoveData_AngularSpd(){ return sizeof(LFloat); }
        private int _GetOffsetOfMoveData_DeltaDeg(){var tempObj =  new MoveData(); MoveData* ptr = &tempObj; var filedPtr = &(ptr->DeltaDeg);return (int)((long) filedPtr - (long) ptr);        }
        private int _GetSizeOfMoveData_DeltaDeg(){ return sizeof(LFloat); }        

#endregion

        internal int CurTotalEntityCount =>
            0 
            + CurPlayerCubeCount            
            ;


    }
}                                                                                
                                                                                         