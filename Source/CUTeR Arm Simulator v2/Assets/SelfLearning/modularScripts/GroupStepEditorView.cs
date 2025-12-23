// using UnityEngine;
// using UnityEditor;
// using System;
// using System.Collections.Generic;

// #if UNITY_EDITOR

// public class GroupStepEditorView
// {
//     private Action<LessonStep> onStepSelected;
//     private Action onDirty;
//     private GroupLessonStep currentGroupStep;
//     private LessonSO lessonAsset;
//     private LessonStep selectedSubStep;
//     // public override void OnInspectorGUI()
//     // {
//     //     serializedObject.Update();

//     //     // Draw the inherited Description field (if serialized!)
//     //     EditorGUILayout.PropertyField(serializedObject.FindProperty("Description"), new GUIContent("Description"));
//     //     serializedObject.ApplyModifiedProperties();
//     // }

//     public GroupStepEditorView(Action<LessonStep> onStepSelected, Action onDirty)
//     {
//         this.onStepSelected = onStepSelected;
//         this.onDirty = onDirty;
//     }

//     public void Draw(GroupLessonStep groupStep, LessonSO lessonAsset, LessonStep selectedSubStep)
//     {
//         this.currentGroupStep = groupStep;
//         this.lessonAsset = lessonAsset;
//         this.selectedSubStep = selectedSubStep;

//         EditorGUILayout.LabelField("Group Step Editor", EditorStyles.boldLabel);
//         if (groupStep.steps == null)
//             groupStep.steps = new List<LessonStep>();

//         // Substep outliner
//         for (int i = 0; i < groupStep.steps.Count; i++)
//         {
//             LessonStep subStep = groupStep.steps[i];
//             EditorGUILayout.BeginHorizontal();

//             if (GUILayout.Toggle(selectedSubStep == subStep, subStep != null ? subStep.Description : "NULL", "Button"))
//             {
//                 if (subStep != null)
//                     onStepSelected?.Invoke(subStep);
//             }

//             if (GUILayout.Button("Remove", GUILayout.Width(60)))
//             {
//                 RemoveSubStep(i);
//                 return;
//             }

//             EditorGUILayout.EndHorizontal();
//         }

//         EditorGUILayout.Space();

//         // Add substep menu
//     //     if (GUILayout.Button("Add Substep ▼", GUILayout.Width(150)))
//     //     {
//     //         ShowAddSubStepMenu();
//     //     }
//     // }

//     // void ShowAddSubStepMenu()
//     // {
//     //     GenericMenu menu = new GenericMenu();
//     //     menu.AddItem(new GUIContent("Play Audio"), false, () => AddSubStep<PlayAudioStep>("Play Audio Step"));
//     //     menu.AddItem(new GUIContent("Virtual Objects Interpolation"), false, () => AddSubStep<VirtualObjects_Interpolation>("Virtual Objects Interpolation"));
//     //     menu.AddItem(new GUIContent("Movement"), false, () => AddSubStep<MovementStep>("Movement Step"));
//     //     menu.AddItem(new GUIContent("Movement_trajectory"), false, () => AddSubStep<Movement_trajectory>("Movement Trajectory Step"));
//     //     menu.AddItem(new GUIContent("Move joint"), false, () => AddSubStep<MoveJointStep>("Move Joint Step"));
//     //     menu.AddItem(new GUIContent("Play Video"), false, () => AddSubStep<VideoPlayStep>("Play Video Step"));
//     //     menu.AddItem(new GUIContent("Show Image"), false, () => AddSubStep<ShowImageStep>("Show Image Step"));
//     //     menu.AddItem(new GUIContent("Show Matrix"), false, () => AddSubStep<MatrixDisplay>("Show Matrix Step"));
//     //     menu.AddItem(new GUIContent("Matrix calculation"), false, () => AddSubStep<MatrixCalculation>("Matrix Calculation Step"));
//     //     menu.AddItem(new GUIContent("Group step"), false, () => AddSubStep<GroupLessonStep>("Group Step"));
//     //     menu.AddItem(new GUIContent("Virtual Objects Show"), false, () => AddSubStep<virtualObjects_show>("Virtual Objects Show/Hide"));
//     //     menu.AddItem(new GUIContent("Loop step"), false, () => AddSubStep<LoopStep>("Loop Step"));
//     //     menu.AddItem(new GUIContent("knightcorrectmove"), false, () => AddSubStep<knightcorrectmove>("Knight Wrong Move Step"));
//     //     menu.AddItem(new GUIContent("bishopcorrectmove"), false, () => AddSubStep<bishopcorrectmove>("Bishop Correct Move Step"));
//     //     menu.AddItem(new GUIContent("bishopwrongmove"), false, () => AddSubStep<bishopwrongmove>("Bishop Wrong Move Step"));
//     //     menu.ShowAsContext();
//     // }

// //     private void AddSubStep<T>(string defaultDescription) where T : LessonStep
// //     {
// //         // Create subasset
// //         T step = ScriptableObject.CreateInstance<T>();
// //         step.name = typeof(T).Name + "_" + currentGroupStep.steps.Count;
// //         step.Description = defaultDescription;

// //         AssetDatabase.AddObjectToAsset(step, lessonAsset);
// //         AssetDatabase.SaveAssets();
// //         currentGroupStep.steps.Add(step);

// //         EditorUtility.SetDirty(currentGroupStep);
// //         EditorUtility.SetDirty(lessonAsset);
// //         AssetDatabase.Refresh();

// //         onDirty?.Invoke();
// //         onStepSelected?.Invoke(step);
// //     }

// //     private void RemoveSubStep(int index)
// //     {
// //         var step = currentGroupStep.steps[index];
// //         currentGroupStep.steps.RemoveAt(index);

// //         UnityEngine.Object.DestroyImmediate(step, true);
// //         AssetDatabase.SaveAssets();
// //         EditorUtility.SetDirty(currentGroupStep);
// //         EditorUtility.SetDirty(lessonAsset);
// //         AssetDatabase.Refresh();

// //         onDirty?.Invoke();
// //         if (selectedSubStep == step)
// //             onStepSelected?.Invoke(null);
// //     }
// // }

// #endif