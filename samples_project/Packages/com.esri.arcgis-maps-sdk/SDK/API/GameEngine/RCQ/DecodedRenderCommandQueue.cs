// COPYRIGHT 1995-2021 ESRI
// TRADE SECRETS: ESRI PROPRIETARY AND CONFIDENTIAL
// Unpublished material - all rights reserved under the
// Copyright Laws of the United States and applicable international
// laws, treaties, and conventions.
//
// For additional information, contact:
// Attn: Contracts and Legal Department
// Environmental Systems Research Institute, Inc.
// 380 New York Street
// Redlands, California 92373
// USA
//
// email: legal@esri.com
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Esri.GameEngine.RCQ
{
	internal class DecodedRenderCommandQueue
	{
		private readonly Unity.ArcGISDataBuffer<byte> rawRenderCommands;
		private ulong currentOffset = 0;

		public DecodedRenderCommandQueue(Unity.ArcGISDataBuffer<byte> rawRenderCommands)
		{
			this.rawRenderCommands = rawRenderCommands;
		}

		public RenderCommand GetNextCommand()
		{
			if (currentOffset < rawRenderCommands.SizeBytes)
			{
				var commandType = GetCommandType(rawRenderCommands);

				switch (commandType)
				{
					case ArcGISRenderCommandType.CreateRenderTarget:
						{
							var parameters = GetCommandParams<ArcGISCreateRenderTargetCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.CreateRenderTarget, parameters);
						}
					case ArcGISRenderCommandType.CreateTexture:
						{
							var parameters = GetCommandParams<ArcGISCreateTextureCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.CreateTexture, parameters);
						}
					case ArcGISRenderCommandType.CreateRenderable:
						{
							var parameters = GetCommandParams<ArcGISCreateRenderableCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.CreateRenderable, parameters);
						}
					case ArcGISRenderCommandType.DestroyRenderTarget:
						{
							var parameters = GetCommandParams<ArcGISDestroyRenderTargetCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.DestroyRenderTarget, parameters);
						}
					case ArcGISRenderCommandType.DestroyTexture:
						{
							var parameters = GetCommandParams<ArcGISDestroyTextureCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.DestroyTexture, parameters);
						}
					case ArcGISRenderCommandType.DestroyRenderable:
						{
							var parameters = GetCommandParams<ArcGISDestroyRenderableCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.DestroyRenderable, parameters);
						}
					case ArcGISRenderCommandType.MultipleCompose:
						{
							var parameters = GetCommandParams<ArcGISMultipleComposeCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.MultipleCompose, parameters);
						}
					case ArcGISRenderCommandType.Copy:
						{
							var parameters = GetCommandParams<ArcGISCopyCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.Copy, parameters);
						}
					case ArcGISRenderCommandType.GenerateNormalTexture:
						{
							var parameters = GetCommandParams<ArcGISGenerateNormalTextureCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.GenerateNormalTexture, parameters);
						}
					case ArcGISRenderCommandType.SetTexturePixelData:
						{
							var parameters = GetCommandParams<ArcGISSetTexturePixelDataCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetTexturePixelData, parameters);
						}
					case ArcGISRenderCommandType.SetRenderableMaterialScalarProperty:
						{
							var parameters = GetCommandParams<ArcGISSetRenderableMaterialScalarPropertyCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetRenderableMaterialScalarProperty, parameters);
						}
					case ArcGISRenderCommandType.SetRenderableMaterialVectorProperty:
						{
							var parameters = GetCommandParams<ArcGISSetRenderableMaterialVectorPropertyCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetRenderableMaterialVectorProperty, parameters);
						}
					case ArcGISRenderCommandType.SetRenderableMaterialRenderTargetProperty:
						{
							var parameters = GetCommandParams<ArcGISSetRenderableMaterialRenderTargetPropertyCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetRenderableMaterialRenderTargetProperty, parameters);
						}
					case ArcGISRenderCommandType.SetRenderableMaterialTextureProperty:
						{
							var parameters = GetCommandParams<ArcGISSetRenderableMaterialTexturePropertyCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetRenderableMaterialTextureProperty, parameters);
						}
					case ArcGISRenderCommandType.SetRenderableMaterialNamedTextureProperty:
						{
							var parameters = GetCommandParams<ArcGISSetRenderableMaterialNamedTexturePropertyCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetRenderableMaterialNamedTextureProperty, parameters);
						}
					case ArcGISRenderCommandType.SetRenderableVisible:
						{
							var parameters = GetCommandParams<ArcGISSetRenderableVisibleCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetRenderableVisible, parameters);
						}
					case ArcGISRenderCommandType.SetRenderableMesh:
						{
							var parameters = GetCommandParams<ArcGISSetRenderableMeshCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetRenderableMesh, parameters);
						}
					case ArcGISRenderCommandType.SetRenderablePivot:
						{
							var parameters = GetCommandParams<ArcGISSetRenderablePivotCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.SetRenderablePivot, parameters);
						}
					case ArcGISRenderCommandType.CommandGroupBegin:
						{
							var parameters = GetCommandParams<ArcGISNullCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.CommandGroupBegin, parameters);
						}
					case ArcGISRenderCommandType.CommandGroupEnd:
						{
							var parameters = GetCommandParams<ArcGISNullCommandParameters>(rawRenderCommands);
							return new RenderCommand(ArcGISRenderCommandType.CommandGroupEnd, parameters);
						}
					default:
						Debug.Fail("Cannot decode unknown renderCommand type {commandType}");
						break;
				}
			}

			return null;
		}

		private ArcGISRenderCommandType GetCommandType(Unity.ArcGISDataBuffer<byte> dataBuffer)
		{
			ArcGISRenderCommandType commandType;
			System.IntPtr unmanagedElement = new System.IntPtr(dataBuffer.Data.ToInt64() + (long)currentOffset);

			unsafe
			{
				commandType = *((ArcGISRenderCommandType*)unmanagedElement.ToPointer());
			}

			var typeSize = (ulong)sizeof(ArcGISRenderCommandType);
			currentOffset += typeSize;

			return commandType;
		}

		private T GetCommandParams<T>(Unity.ArcGISDataBuffer<byte> dataBuffer)
		{
			var typeSize = (ulong)Marshal.SizeOf(typeof(T));

			System.IntPtr unmanagedElement = new System.IntPtr(dataBuffer.Data.ToInt64() + (long)currentOffset);
			var commandParameters = Marshal.PtrToStructure<T>(unmanagedElement);

			currentOffset += typeSize;

			return commandParameters;
		}
	}
}
