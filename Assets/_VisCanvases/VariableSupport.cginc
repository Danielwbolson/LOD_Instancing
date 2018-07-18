#ifndef VARIABLESUPPORT_INCLUDED
#define VARIABLESUPPORT_INCLUDED

#include "GeneralSupport.cginc"
#include "CanvasSupport.cginc"
int _VariableAssigned_0;
int _VariableDomainDimensionality_0;
int _VariableComponents_0;
float3 _VariableMin_0;
float3 _VariableMax_0;
sampler3D _Variable3DTexture_0;
int _VariableArrayType_0;
StructuredBuffer<float> _VariableDataBuffer_0;
float3 _VariableDefaultValue_0;
float4x4 _VariableBoundsMatrixInv_0;

int _VariableAssigned_1;
int _VariableDomainDimensionality_1;
int _VariableComponents_1;
float3 _VariableMin_1;
float3 _VariableMax_1;
sampler3D _Variable3DTexture_1;
int _VariableArrayType_1;
StructuredBuffer<float> _VariableDataBuffer_1;
float3 _VariableDefaultValue_1;
float4x4 _VariableBoundsMatrixInv_1;

int _VariableAssigned_2;
int _VariableDomainDimensionality_2;
int _VariableComponents_2;
float3 _VariableMin_2;
float3 _VariableMax_2;
sampler3D _Variable3DTexture_2;
int _VariableArrayType_2;
StructuredBuffer<float> _VariableDataBuffer_2;
float3 _VariableDefaultValue_2;
float4x4 _VariableBoundsMatrixInv_2;

int _VariableAssigned_3;
int _VariableDomainDimensionality_3;
int _VariableComponents_3;
float3 _VariableMin_3;
float3 _VariableMax_3;
sampler3D _Variable3DTexture_3;
int _VariableArrayType_3;
StructuredBuffer<float> _VariableDataBuffer_3;
float3 _VariableDefaultValue_3;
float4x4 _VariableBoundsMatrixInv_3;

int _VariableAssigned_4;
int _VariableDomainDimensionality_4;
int _VariableComponents_4;
float3 _VariableMin_4;
float3 _VariableMax_4;
sampler3D _Variable3DTexture_4;
int _VariableArrayType_4;
StructuredBuffer<float> _VariableDataBuffer_4;
float3 _VariableDefaultValue_4;
float4x4 _VariableBoundsMatrixInv_4;

int _VariableAssigned_5;
int _VariableDomainDimensionality_5;
int _VariableComponents_5;
float3 _VariableMin_5;
float3 _VariableMax_5;
sampler3D _Variable3DTexture_5;
int _VariableArrayType_5;
StructuredBuffer<float> _VariableDataBuffer_5;
float3 _VariableDefaultValue_5;
float4x4 _VariableBoundsMatrixInv_5;

int _VariableAssigned_6;
int _VariableDomainDimensionality_6;
int _VariableComponents_6;
float3 _VariableMin_6;
float3 _VariableMax_6;
sampler3D _Variable3DTexture_6;
int _VariableArrayType_6;
StructuredBuffer<float> _VariableDataBuffer_6;
float3 _VariableDefaultValue_6;
float4x4 _VariableBoundsMatrixInv_6;

int _VariableAssigned_7;
int _VariableDomainDimensionality_7;
int _VariableComponents_7;
float3 _VariableMin_7;
float3 _VariableMax_7;
sampler3D _Variable3DTexture_7;
int _VariableArrayType_7;
StructuredBuffer<float> _VariableDataBuffer_7;
float3 _VariableDefaultValue_7;
float4x4 _VariableBoundsMatrixInv_7;

int _VariableAssigned_8;
int _VariableDomainDimensionality_8;
int _VariableComponents_8;
float3 _VariableMin_8;
float3 _VariableMax_8;
sampler3D _Variable3DTexture_8;
int _VariableArrayType_8;
StructuredBuffer<float> _VariableDataBuffer_8;
float3 _VariableDefaultValue_8;
float4x4 _VariableBoundsMatrixInv_8;

int _VariableAssigned_9;
int _VariableDomainDimensionality_9;
int _VariableComponents_9;
float3 _VariableMin_9;
float3 _VariableMax_9;
sampler3D _Variable3DTexture_9;
int _VariableArrayType_9;
StructuredBuffer<float> _VariableDataBuffer_9;
float3 _VariableDefaultValue_9;
float4x4 _VariableBoundsMatrixInv_9;

int GetVariableArrayType(int variableSlot) {
    switch (variableSlot) {
        case 0: 
            return _VariableArrayType_0;
            break;
        case 1: 
            return _VariableArrayType_1;
            break;
        case 2: 
            return _VariableArrayType_2;
            break;
        case 3: 
            return _VariableArrayType_3;
            break;
        case 4: 
            return _VariableArrayType_4;
            break;
        case 5: 
            return _VariableArrayType_5;
            break;
        case 6: 
            return _VariableArrayType_6;
            break;
        case 7: 
            return _VariableArrayType_7;
            break;
        case 8: 
            return _VariableArrayType_8;
            break;
        case 9: 
            return _VariableArrayType_9;
            break;
        default:
            return 0;
    }    
}

int GetVariableDomainDimensionality(int variableSlot) {
    switch (variableSlot) {
        case 0: 
            return _VariableDomainDimensionality_0;
            break;
        case 1: 
            return _VariableDomainDimensionality_1;
            break;
        case 2: 
            return _VariableDomainDimensionality_2;
            break;
        case 3: 
            return _VariableDomainDimensionality_3;
            break;
        case 4: 
            return _VariableDomainDimensionality_4;
            break;
        case 5: 
            return _VariableDomainDimensionality_5;
            break;
        case 6: 
            return _VariableDomainDimensionality_6;
            break;
        case 7: 
            return _VariableDomainDimensionality_7;
            break;
        case 8: 
            return _VariableDomainDimensionality_8;
            break;
        case 9: 
            return _VariableDomainDimensionality_9;
            break;
        default:
            return 0;
    }    
}


int GetVariableComponents(int variableSlot) {
    switch (variableSlot) {
        case 0: 
            return _VariableComponents_0;
            break;
        case 1: 
            return _VariableComponents_1;
            break;
        case 2: 
            return _VariableComponents_2;
            break;
        case 3: 
            return _VariableComponents_3;
            break;
        case 4: 
            return _VariableComponents_4;
            break;
        case 5: 
            return _VariableComponents_5;
            break;
        case 6: 
            return _VariableComponents_6;
            break;
        case 7: 
            return _VariableComponents_7;
            break;
        case 8: 
            return _VariableComponents_8;
            break;
        case 9: 
            return _VariableComponents_9;
            break;
        default:
            return 0;
    }    
}

float4 GetVariable3DTextureSample(int variableSlot, float3 dataPos) {
    float4 uvwt = float4(dataPos+0.5,0);
    switch (variableSlot) {
        case 0: 
            return tex3Dlod (_Variable3DTexture_0,uvwt);
            break;
        case 1: 
            return tex3Dlod(_Variable3DTexture_1,uvwt);
            break;
        case 2: 
            return tex3Dlod(_Variable3DTexture_2,uvwt);
            break;
        case 3: 
            return tex3Dlod(_Variable3DTexture_3,uvwt);
            break;
        case 4: 
            return tex3Dlod(_Variable3DTexture_4,uvwt);
            break;
        case 5: 
            return tex3Dlod(_Variable3DTexture_5,uvwt);
            break;
        case 6: 
            return tex3Dlod(_Variable3DTexture_6,uvwt);
            break;
        case 7: 
            return tex3Dlod(_Variable3DTexture_7,uvwt);
            break;
        case 8: 
            return tex3Dlod(_Variable3DTexture_8,uvwt);
            break;
        case 9: 
            return tex3Dlod(_Variable3DTexture_9,uvwt);
            break;
        default:
            return tex3Dlod(_Variable3DTexture_0,uvwt);
    }
}

float3 GetVariableStructuredBufferSample(int variableSlot, int index) {
    int components = GetVariableComponents(variableSlot);
    if(components == 1){
        switch (variableSlot) {
            case 0: 
                return float3(_VariableDataBuffer_0[index],0,0);
                break;
            case 1: 
                return float3(_VariableDataBuffer_1[index],0,0);
                break;
            case 2: 
                return float3(_VariableDataBuffer_2[index],0,0);
                break;
            case 3: 
                return float3(_VariableDataBuffer_3[index],0,0);
                break;
            case 4: 
                return float3(_VariableDataBuffer_4[index],0,0);
                break;
            case 5: 
                return float3(_VariableDataBuffer_5[index],0,0);
                break;
            case 6: 
                return float3(_VariableDataBuffer_6[index],0,0);
                break;
            case 7: 
                return float3(_VariableDataBuffer_7[index],0,0);
                break;
            case 8: 
                return float3(_VariableDataBuffer_8[index],0,0);
                break;
            case 9: 
                return float3(_VariableDataBuffer_9[index],0,0);
                break;

            default:
                return float3(0,0,0);
        }
    }else{
        switch (variableSlot) {
            
            case 0: 
                return float3(_VariableDataBuffer_0[index*3+0],_VariableDataBuffer_0[index*3+1],_VariableDataBuffer_0[index*3+2]);
                break;
            case 1: 
                return float3(_VariableDataBuffer_1[index*3+0],_VariableDataBuffer_1[index*3+1],_VariableDataBuffer_1[index*3+2]);
                break;
            case 2: 
                return float3(_VariableDataBuffer_2[index*3+0],_VariableDataBuffer_2[index*3+1],_VariableDataBuffer_2[index*3+2]);
                break;
            case 3: 
                return float3(_VariableDataBuffer_3[index*3+0],_VariableDataBuffer_3[index*3+1],_VariableDataBuffer_3[index*3+2]);
                break;
            case 4: 
                return float3(_VariableDataBuffer_4[index*3+0],_VariableDataBuffer_4[index*3+1],_VariableDataBuffer_4[index*3+2]);
                break;
            case 5: 
                return float3(_VariableDataBuffer_5[index*3+0],_VariableDataBuffer_5[index*3+1],_VariableDataBuffer_5[index*3+2]);
                break;
            case 6: 
                return float3(_VariableDataBuffer_6[index*3+0],_VariableDataBuffer_6[index*3+1],_VariableDataBuffer_6[index*3+2]);
                break;
            case 7: 
                return float3(_VariableDataBuffer_7[index*3+0],_VariableDataBuffer_7[index*3+1],_VariableDataBuffer_7[index*3+2]);
                break;
            case 8: 
                return float3(_VariableDataBuffer_8[index*3+0],_VariableDataBuffer_8[index*3+1],_VariableDataBuffer_8[index*3+2]);
                break;
            case 9: 
                return float3(_VariableDataBuffer_9[index*3+0],_VariableDataBuffer_9[index*3+1],_VariableDataBuffer_9[index*3+2]);
                break;

            default:
                return float3(0,0,0);
        }
    }
}

float3 GetVariableDefaultValue(int variableSlot) {
    switch (variableSlot) {
        case 0: 
            return _VariableDefaultValue_0;
            break;
        case 1: 
            return _VariableDefaultValue_1;
            break;
        case 2: 
            return _VariableDefaultValue_2;
            break;
        case 3: 
            return _VariableDefaultValue_3;
            break;
        case 4: 
            return _VariableDefaultValue_4;
            break;
        case 5: 
            return _VariableDefaultValue_5;
            break;
        case 6: 
            return _VariableDefaultValue_6;
            break;
        case 7: 
            return _VariableDefaultValue_7;
            break;
        case 8: 
            return _VariableDefaultValue_8;
            break;
        case 9: 
            return _VariableDefaultValue_9;
            break;
        default:
            return float3(0,0,0);
    }
}

int VariableIsAssigned(int variableSlot) {
    switch (variableSlot) {
       case 0: 
            return _VariableAssigned_0;
            break;
        case 1: 
            return _VariableAssigned_1;
            break;
        case 2: 
            return _VariableAssigned_2;
            break;
        case 3: 
            return _VariableAssigned_3;
            break;
        case 4: 
            return _VariableAssigned_4;
            break;
        case 5: 
            return _VariableAssigned_5;
            break;
        case 6: 
            return _VariableAssigned_6;
            break;
        case 7: 
            return _VariableAssigned_7;
            break;
        case 8: 
            return _VariableAssigned_8;
            break;
        case 9: 
            return _VariableAssigned_9;
            break;
        default:
            return 0;
    }
}

float4x4 GetVariableBoundsMatrixInv(int variableSlot) {
    switch (variableSlot) {
        case 0: 
            return _VariableBoundsMatrixInv_0;
            break;
        case 1: 
            return _VariableBoundsMatrixInv_1;
            break;
        case 2: 
            return _VariableBoundsMatrixInv_2;
            break;
        case 3: 
            return _VariableBoundsMatrixInv_3;
            break;
        case 4: 
            return _VariableBoundsMatrixInv_4;
            break;
        case 5: 
            return _VariableBoundsMatrixInv_5;
            break;
        case 6: 
            return _VariableBoundsMatrixInv_6;
            break;
        case 7: 
            return _VariableBoundsMatrixInv_7;
            break;
        case 8: 
            return _VariableBoundsMatrixInv_8;
            break;
        case 9: 
            return _VariableBoundsMatrixInv_9;
            break;
            return float4x4(1,0,0,0,0,1,0,0,0,0,1,0,0,0,0,1);
    }
}

float3 GetVariableMin(int variableSlot) {
    switch (variableSlot) {
        case 0: 
            return _VariableMin_0;
            break;
        case 1: 
            return _VariableMin_1;
            break;
        case 2: 
            return _VariableMin_2;
            break;
        case 3: 
            return _VariableMin_3;
            break;
        case 4: 
            return _VariableMin_4;
            break;
        case 5: 
            return _VariableMin_5;
            break;
        case 6: 
            return _VariableMin_6;
            break;
        case 7: 
            return _VariableMin_7;
            break;
        case 8: 
            return _VariableMin_8;
            break;
        case 9: 
            return _VariableMin_9;
            break;
        default:
            return 0;
    }
}

float3 GetVariableMax(int variableSlot) {
    switch (variableSlot) {
        case 0: 
            return _VariableMax_0;
            break;
        case 1: 
            return _VariableMax_1;
            break;
        case 2: 
            return _VariableMax_2;
            break;
        case 3: 
            return _VariableMax_3;
            break;
        case 4: 
            return _VariableMax_4;
            break;
        case 5: 
            return _VariableMax_5;
            break;
        case 6: 
            return _VariableMax_6;
            break;
        case 7: 
            return _VariableMax_7;
            break;
        case 8: 
            return _VariableMax_8;
            break;
        case 9: 
            return _VariableMax_9;
            break;
        default:
            return 0;
    }
}

float3 GetDataPosition(int variableSlot, float3 worldPos) {
    float4 worldSpace = float4(worldPos,1);
    float4 canvasSpace = mul(_CanvasInverse,worldSpace);
    float4 innerSceneSpace = mul(_CanvasInnerSceneInverse,worldSpace);
    float4 dataSpace = mul(GetVariableBoundsMatrixInv(variableSlot),innerSceneSpace);
    return dataSpace;
}
float3 NormalizeData(int variableSlot, float3 data) {
    float3 result;
    if(GetVariableComponents(variableSlot) == 1) {
        float3 MIN = GetVariableMin(variableSlot);
        float3 MAX = GetVariableMax(variableSlot);
        if(abs(MIN.x-MAX.x) < 0.0000001)
            result.x = MIN.x; 
        else 
            result.x = map(data.x,MIN.x,MAX.x,0,1);

        if(abs(MIN.y-MAX.y) < 0.0000001)
            result.y = MIN.y; 
        else 
            result.y = map(data.y,MIN.y,MAX.y,0,1); 

        if(abs(MIN.z-MAX.z) < 0.0000001)
            result.z = MIN.z; 
        else 
            result.z = map(data.z,MIN.z,MAX.z,0,1); 
    } else {
        result = normalize(data);
    }
    return result;

}
float GetMagnitude(int variableSlot, float3 data) {
    if(GetVariableComponents(variableSlot) == 1)
        return data.x;
    else if(GetVariableComponents(variableSlot) == 3 && length(data) > 0.000001) 
        return length(data);
    else return 0; 
        
}
float3 GetData(int variableSlot, int cellId, int vertexId, float3 dataPos) {
    if(VariableIsAssigned(variableSlot) == 0)
        return GetVariableDefaultValue(variableSlot);
    float3 result = float3(0,0,0);
    int dim = GetVariableDomainDimensionality(variableSlot);
    switch(dim) {
        case 3:
            result = GetVariable3DTextureSample(variableSlot,dataPos).xyz;
            break;
        case 1:
         //result = float3(cellId/20.0,0,0);break;
            result = GetVariableStructuredBufferSample(variableSlot,GetVariableArrayType(variableSlot) == 1? vertexId:cellId);
            break;
        default:
         result = float3(0.5,0.5,0.5);
            break; 
    }
    return result;
   
}

#endif
