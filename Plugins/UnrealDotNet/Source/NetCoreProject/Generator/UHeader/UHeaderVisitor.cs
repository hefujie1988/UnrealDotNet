//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from UHeader.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="UHeaderParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IUHeaderVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.translationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTranslationUnit([NotNull] UHeaderParser.TranslationUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.namespaceUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceUnit([NotNull] UHeaderParser.NamespaceUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.namespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceName([NotNull] UHeaderParser.NamespaceNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.typePreDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypePreDeclaration([NotNull] UHeaderParser.TypePreDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclaration([NotNull] UHeaderParser.ClassDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.classOrStructOrEnum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassOrStructOrEnum([NotNull] UHeaderParser.ClassOrStructOrEnumContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.classOrStruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassOrStruct([NotNull] UHeaderParser.ClassOrStructContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.classParentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassParentList([NotNull] UHeaderParser.ClassParentListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.classAlignDefine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassAlignDefine([NotNull] UHeaderParser.ClassAlignDefineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.classAlignValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassAlignValue([NotNull] UHeaderParser.ClassAlignValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassBody([NotNull] UHeaderParser.ClassBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] UHeaderParser.CommentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumDeclaration([NotNull] UHeaderParser.EnumDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.enumParent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumParent([NotNull] UHeaderParser.EnumParentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.enumElementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumElementList([NotNull] UHeaderParser.EnumElementListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.enumElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumElement([NotNull] UHeaderParser.EnumElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.enumElementName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumElementName([NotNull] UHeaderParser.EnumElementNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.unionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnionDeclaration([NotNull] UHeaderParser.UnionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.typeDefine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeDefine([NotNull] UHeaderParser.TypeDefineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.uDefine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUDefine([NotNull] UHeaderParser.UDefineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.uDefineName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUDefineName([NotNull] UHeaderParser.UDefineNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.uMeta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUMeta([NotNull] UHeaderParser.UMetaContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.uMetaParametrList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUMetaParametrList([NotNull] UHeaderParser.UMetaParametrListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.uMetaParametr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUMetaParametr([NotNull] UHeaderParser.UMetaParametrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.uMetaParamKey"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUMetaParamKey([NotNull] UHeaderParser.UMetaParamKeyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.uMetaParamValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUMetaParamValue([NotNull] UHeaderParser.UMetaParamValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.undefineBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUndefineBlock([NotNull] UHeaderParser.UndefineBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.undefineContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUndefineContent([NotNull] UHeaderParser.UndefineContentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.constructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructor([NotNull] UHeaderParser.ConstructorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.constructorInitializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorInitializerList([NotNull] UHeaderParser.ConstructorInitializerListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.constructorInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorInitializer([NotNull] UHeaderParser.ConstructorInitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethod([NotNull] UHeaderParser.MethodContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.methodParamsList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodParamsList([NotNull] UHeaderParser.MethodParamsListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.methodParametr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodParametr([NotNull] UHeaderParser.MethodParametrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.methodParametrName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodParametrName([NotNull] UHeaderParser.MethodParametrNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.methodParametrDefaultValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodParametrDefaultValue([NotNull] UHeaderParser.MethodParametrDefaultValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] UHeaderParser.ValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodBody([NotNull] UHeaderParser.MethodBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.methodBodyContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodBodyContent([NotNull] UHeaderParser.MethodBodyContentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodName([NotNull] UHeaderParser.MethodNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.methodOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodOperator([NotNull] UHeaderParser.MethodOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProperty([NotNull] UHeaderParser.PropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.propertyName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyName([NotNull] UHeaderParser.PropertyNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.propertyDefaultValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyDefaultValue([NotNull] UHeaderParser.PropertyDefaultValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] UHeaderParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isPtrQuant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsPtrQuant([NotNull] UHeaderParser.IsPtrQuantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isRefQuant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsRefQuant([NotNull] UHeaderParser.IsRefQuantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] UHeaderParser.TypeNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.typeTemplateName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeTemplateName([NotNull] UHeaderParser.TypeTemplateNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isVirtual"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsVirtual([NotNull] UHeaderParser.IsVirtualContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isOverride"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsOverride([NotNull] UHeaderParser.IsOverrideContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isConst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsConst([NotNull] UHeaderParser.IsConstContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isStatic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsStatic([NotNull] UHeaderParser.IsStaticContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isFriend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsFriend([NotNull] UHeaderParser.IsFriendContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isFinal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsFinal([NotNull] UHeaderParser.IsFinalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isDestructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsDestructor([NotNull] UHeaderParser.IsDestructorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isDelete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsDelete([NotNull] UHeaderParser.IsDeleteContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.isArray"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsArray([NotNull] UHeaderParser.IsArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.arrayLen"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayLen([NotNull] UHeaderParser.ArrayLenContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.templateDefine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateDefine([NotNull] UHeaderParser.TemplateDefineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.templateParamList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateParamList([NotNull] UHeaderParser.TemplateParamListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.templateParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateParam([NotNull] UHeaderParser.TemplateParamContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.templateParamType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateParamType([NotNull] UHeaderParser.TemplateParamTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.templateParamLiter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateParamLiter([NotNull] UHeaderParser.TemplateParamLiterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.accessSpecifierContainer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessSpecifierContainer([NotNull] UHeaderParser.AccessSpecifierContainerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.accessSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessSpecifier([NotNull] UHeaderParser.AccessSpecifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UHeaderParser.preprocessDerective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreprocessDerective([NotNull] UHeaderParser.PreprocessDerectiveContext context);
}
