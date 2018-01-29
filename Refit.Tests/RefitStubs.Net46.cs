﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Xunit;
using Nustache;
using Nustache.Core;
using Refit;
using Refit.Generator;
using Task =  System.Threading.Tasks.Task;
using System.Net;
using System.Reactive.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RichardSzalay.MockHttp;
using static System.Math;
using SomeType =  CollisionA.SomeType;
using CollisionB;
using System.Reflection;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIAmARefitInterfaceButNobodyUsesMe : IAmARefitInterfaceButNobodyUsesMe
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIAmARefitInterfaceButNobodyUsesMe(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("RefitMethod()", requestBuilder.BuildRestResultFuncForMethod("RefitMethod", new Type[] {  }));
            methodImpls.Add("AnotherRefitMethod()", requestBuilder.BuildRestResultFuncForMethod("AnotherRefitMethod", new Type[] {  }));
            methodImpls.Add("SpacesShouldntBreakMe()", requestBuilder.BuildRestResultFuncForMethod("SpacesShouldntBreakMe", new Type[] {  }));
            methodImpls.Add("ReservedWordsForParameterNames(int @int,string @string,float @long)", requestBuilder.BuildRestResultFuncForMethod("ReservedWordsForParameterNames", new Type[] { typeof(int),typeof(string),typeof(float) }));
        }

        /// <inheritdoc />
        public virtual Task RefitMethod()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["RefitMethod()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task AnotherRefitMethod()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["AnotherRefitMethod()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NoConstantsAllowed()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

        /// <inheritdoc />
        public virtual Task SpacesShouldntBreakMe()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["SpacesShouldntBreakMe()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task ReservedWordsForParameterNames(int @int,string @string,float @long)
        {
            var arguments = new object[] { @int,@string,@long };
            return (Task) methodImpls["ReservedWordsForParameterNames(int @int,string @string,float @long)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIAmHalfRefit : IAmHalfRefit
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIAmHalfRefit(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("Post()", requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] {  }));
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Post()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Get()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIApiWithDecimal : IApiWithDecimal
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIApiWithDecimal(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("GetWithDecimal(decimal value)", requestBuilder.BuildRestResultFuncForMethod("GetWithDecimal", new Type[] { typeof(decimal) }));
        }

        /// <inheritdoc />
        public virtual Task<string> GetWithDecimal(decimal value)
        {
            var arguments = new object[] { value };
            return (Task<string>) methodImpls["GetWithDecimal(decimal value)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIBodylessApi : IBodylessApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIBodylessApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("Post()", requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] {  }));
            methodImpls.Add("Get()", requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  }));
            methodImpls.Add("Head()", requestBuilder.BuildRestResultFuncForMethod("Head", new Type[] {  }));
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Post()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Get()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Get()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Head()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Head()"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIBoringCrudApi<T, TKey> : IBoringCrudApi<T, TKey>
        where T : class
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIBoringCrudApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("Create(T paylod)", requestBuilder.BuildRestResultFuncForMethod("Create", new Type[] { typeof(T) }));
            methodImpls.Add("ReadAll()", requestBuilder.BuildRestResultFuncForMethod("ReadAll", new Type[] {  }));
            methodImpls.Add("ReadOne(TKey key)", requestBuilder.BuildRestResultFuncForMethod("ReadOne", new Type[] { typeof(TKey) }));
            methodImpls.Add("Update(TKey key,T payload)", requestBuilder.BuildRestResultFuncForMethod("Update", new Type[] { typeof(TKey),typeof(T) }));
            methodImpls.Add("Delete(TKey key)", requestBuilder.BuildRestResultFuncForMethod("Delete", new Type[] { typeof(TKey) }));
        }

        /// <inheritdoc />
        public virtual Task<T> Create(T paylod)
        {
            var arguments = new object[] { paylod };
            return (Task<T>) methodImpls["Create(T paylod)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<T>> ReadAll()
        {
            var arguments = new object[] {  };
            return (Task<List<T>>) methodImpls["ReadAll()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<T> ReadOne(TKey key)
        {
            var arguments = new object[] { key };
            return (Task<T>) methodImpls["ReadOne(TKey key)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Update(TKey key,T payload)
        {
            var arguments = new object[] { key,payload };
            return (Task) methodImpls["Update(TKey key,T payload)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Delete(TKey key)
        {
            var arguments = new object[] { key };
            return (Task) methodImpls["Delete(TKey key)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIBrokenWebApi : IBrokenWebApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIBrokenWebApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("PostAValue(string derp)", requestBuilder.BuildRestResultFuncForMethod("PostAValue", new Type[] { typeof(string) }));
        }

        /// <inheritdoc />
        public virtual Task<bool> PostAValue(string derp)
        {
            var arguments = new object[] { derp };
            return (Task<bool>) methodImpls["PostAValue(string derp)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIGitHubApi : IGitHubApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("GetUser(string userName)", requestBuilder.BuildRestResultFuncForMethod("GetUser", new Type[] { typeof(string) }));
            methodImpls.Add("GetUserObservable(string userName)", requestBuilder.BuildRestResultFuncForMethod("GetUserObservable", new Type[] { typeof(string) }));
            methodImpls.Add("GetUserCamelCase(string userName)", requestBuilder.BuildRestResultFuncForMethod("GetUserCamelCase", new Type[] { typeof(string) }));
            methodImpls.Add("GetOrgMembers(string orgName)", requestBuilder.BuildRestResultFuncForMethod("GetOrgMembers", new Type[] { typeof(string) }));
            methodImpls.Add("FindUsers(string q)", requestBuilder.BuildRestResultFuncForMethod("FindUsers", new Type[] { typeof(string) }));
            methodImpls.Add("GetIndex()", requestBuilder.BuildRestResultFuncForMethod("GetIndex", new Type[] {  }));
            methodImpls.Add("GetIndexObservable()", requestBuilder.BuildRestResultFuncForMethod("GetIndexObservable", new Type[] {  }));
            methodImpls.Add("NothingToSeeHere()", requestBuilder.BuildRestResultFuncForMethod("NothingToSeeHere", new Type[] {  }));
            methodImpls.Add("GetUserWithMetadata(string userName)", requestBuilder.BuildRestResultFuncForMethod("GetUserWithMetadata", new Type[] { typeof(string) }));
            methodImpls.Add("GetUserObservableWithMetadata(string userName)", requestBuilder.BuildRestResultFuncForMethod("GetUserObservableWithMetadata", new Type[] { typeof(string) }));
            methodImpls.Add("CreateUser(User user)", requestBuilder.BuildRestResultFuncForMethod("CreateUser", new Type[] { typeof(User) }));
        }

        /// <inheritdoc />
        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            return (Task<User>) methodImpls["GetUser(string userName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserObservable(string userName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserCamelCase(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserCamelCase(string userName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            return (Task<List<User>>) methodImpls["GetOrgMembers(string orgName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            return (Task<UserSearchResult>) methodImpls["FindUsers(string q)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            return (Task<HttpResponseMessage>) methodImpls["GetIndex()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            return (IObservable<string>) methodImpls["GetIndexObservable()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NothingToSeeHere()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["NothingToSeeHere()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<User>> GetUserWithMetadata(string userName)
        {
            var arguments = new object[] { userName };
            return (Task<ApiResponse<User>>) methodImpls["GetUserWithMetadata(string userName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<ApiResponse<User>> GetUserObservableWithMetadata(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<ApiResponse<User>>) methodImpls["GetUserObservableWithMetadata(string userName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<User> CreateUser(User user)
        {
            var arguments = new object[] { user };
            return (Task<User>) methodImpls["CreateUser(User user)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIHttpBinApi<TResponse, TParam, THeader> : IHttpBinApi<TResponse, TParam, THeader>
        where TResponse : class
        where THeader : struct
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIHttpBinApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("Get(TParam param,THeader header)", requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(TParam),typeof(THeader) }));
            methodImpls.Add("GetQuery(TParam param)", requestBuilder.BuildRestResultFuncForMethod("GetQuery", new Type[] { typeof(TParam) }));
            methodImpls.Add("GetQueryWithIncludeParameterName(TParam param)", requestBuilder.BuildRestResultFuncForMethod("GetQueryWithIncludeParameterName", new Type[] { typeof(TParam) }));
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(TParam param,THeader header)
        {
            var arguments = new object[] { param,header };
            return (Task<TResponse>) methodImpls["Get(TParam param,THeader header)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> GetQuery(TParam param)
        {
            var arguments = new object[] { param };
            return (Task<TResponse>) methodImpls["GetQuery(TParam param)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> GetQueryWithIncludeParameterName(TParam param)
        {
            var arguments = new object[] { param };
            return (Task<TResponse>) methodImpls["GetQueryWithIncludeParameterName(TParam param)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIHttpContentApi : IHttpContentApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIHttpContentApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("PostFileUpload(HttpContent content)", requestBuilder.BuildRestResultFuncForMethod("PostFileUpload", new Type[] { typeof(HttpContent) }));
            methodImpls.Add("PostFileUploadWithMetadata(HttpContent content)", requestBuilder.BuildRestResultFuncForMethod("PostFileUploadWithMetadata", new Type[] { typeof(HttpContent) }));
        }

        /// <inheritdoc />
        public virtual Task<HttpContent> PostFileUpload(HttpContent content)
        {
            var arguments = new object[] { content };
            return (Task<HttpContent>) methodImpls["PostFileUpload(HttpContent content)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<HttpContent>> PostFileUploadWithMetadata(HttpContent content)
        {
            var arguments = new object[] { content };
            return (Task<ApiResponse<HttpContent>>) methodImpls["PostFileUploadWithMetadata(HttpContent content)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedINamespaceCollisionApi : INamespaceCollisionApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedINamespaceCollisionApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("SomeRequest()", requestBuilder.BuildRestResultFuncForMethod("SomeRequest", new Type[] {  }));
        }

        /// <inheritdoc />
        public virtual Task<SomeType> SomeRequest()
        {
            var arguments = new object[] {  };
            return (Task<SomeType>) methodImpls["SomeRequest()"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedTestNestedINestedGitHubApi : TestNested.INestedGitHubApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedTestNestedINestedGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("GetUser(string userName)", requestBuilder.BuildRestResultFuncForMethod("GetUser", new Type[] { typeof(string) }));
            methodImpls.Add("GetUserObservable(string userName)", requestBuilder.BuildRestResultFuncForMethod("GetUserObservable", new Type[] { typeof(string) }));
            methodImpls.Add("GetUserCamelCase(string userName)", requestBuilder.BuildRestResultFuncForMethod("GetUserCamelCase", new Type[] { typeof(string) }));
            methodImpls.Add("GetOrgMembers(string orgName)", requestBuilder.BuildRestResultFuncForMethod("GetOrgMembers", new Type[] { typeof(string) }));
            methodImpls.Add("FindUsers(string q)", requestBuilder.BuildRestResultFuncForMethod("FindUsers", new Type[] { typeof(string) }));
            methodImpls.Add("GetIndex()", requestBuilder.BuildRestResultFuncForMethod("GetIndex", new Type[] {  }));
            methodImpls.Add("GetIndexObservable()", requestBuilder.BuildRestResultFuncForMethod("GetIndexObservable", new Type[] {  }));
            methodImpls.Add("NothingToSeeHere()", requestBuilder.BuildRestResultFuncForMethod("NothingToSeeHere", new Type[] {  }));
        }

        /// <inheritdoc />
        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            return (Task<User>) methodImpls["GetUser(string userName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserObservable(string userName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserCamelCase(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserCamelCase(string userName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            return (Task<List<User>>) methodImpls["GetOrgMembers(string orgName)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            return (Task<UserSearchResult>) methodImpls["FindUsers(string q)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            return (Task<HttpResponseMessage>) methodImpls["GetIndex()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            return (IObservable<string>) methodImpls["GetIndexObservable()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NothingToSeeHere()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["NothingToSeeHere()"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedINpmJs : INpmJs
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedINpmJs(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("GetCongruence()", requestBuilder.BuildRestResultFuncForMethod("GetCongruence", new Type[] {  }));
        }

        /// <inheritdoc />
        public virtual Task<RootObject> GetCongruence()
        {
            var arguments = new object[] {  };
            return (Task<RootObject>) methodImpls["GetCongruence()"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIRequestBin : IRequestBin
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIRequestBin(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("Post()", requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] {  }));
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Post()"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIRunscopeApi : IRunscopeApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIRunscopeApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("UploadStream(Stream stream)", requestBuilder.BuildRestResultFuncForMethod("UploadStream", new Type[] { typeof(Stream) }));
            methodImpls.Add("UploadStreamPart(StreamPart stream)", requestBuilder.BuildRestResultFuncForMethod("UploadStreamPart", new Type[] { typeof(StreamPart) }));
            methodImpls.Add("UploadBytes(byte[] bytes)", requestBuilder.BuildRestResultFuncForMethod("UploadBytes", new Type[] { typeof(byte[]) }));
            methodImpls.Add("UploadBytesPart(ByteArrayPart bytes)", requestBuilder.BuildRestResultFuncForMethod("UploadBytesPart", new Type[] { typeof(ByteArrayPart) }));
            methodImpls.Add("UploadString(string someString)", requestBuilder.BuildRestResultFuncForMethod("UploadString", new Type[] { typeof(string) }));
            methodImpls.Add("UploadFileInfo(IEnumerable<FileInfo> fileInfos,FileInfo anotherFile)", requestBuilder.BuildRestResultFuncForMethod("UploadFileInfo", new Type[] { typeof(IEnumerable<FileInfo>),typeof(FileInfo) }));
            methodImpls.Add("UploadFileInfoPart(IEnumerable<FileInfoPart> fileInfos,FileInfoPart anotherFile)", requestBuilder.BuildRestResultFuncForMethod("UploadFileInfoPart", new Type[] { typeof(IEnumerable<FileInfoPart>),typeof(FileInfoPart) }));
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadStream(Stream stream)
        {
            var arguments = new object[] { stream };
            return (Task<HttpResponseMessage>) methodImpls["UploadStream(Stream stream)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadStreamPart(StreamPart stream)
        {
            var arguments = new object[] { stream };
            return (Task<HttpResponseMessage>) methodImpls["UploadStreamPart(StreamPart stream)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadBytes(byte[] bytes)
        {
            var arguments = new object[] { bytes };
            return (Task<HttpResponseMessage>) methodImpls["UploadBytes(byte[] bytes)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadBytesPart(ByteArrayPart bytes)
        {
            var arguments = new object[] { bytes };
            return (Task<HttpResponseMessage>) methodImpls["UploadBytesPart(ByteArrayPart bytes)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadString(string someString)
        {
            var arguments = new object[] { someString };
            return (Task<HttpResponseMessage>) methodImpls["UploadString(string someString)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadFileInfo(IEnumerable<FileInfo> fileInfos,FileInfo anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            return (Task<HttpResponseMessage>) methodImpls["UploadFileInfo(IEnumerable<FileInfo> fileInfos,FileInfo anotherFile)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadFileInfoPart(IEnumerable<FileInfoPart> fileInfos,FileInfoPart anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            return (Task<HttpResponseMessage>) methodImpls["UploadFileInfoPart(IEnumerable<FileInfoPart> fileInfos,FileInfoPart anotherFile)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIStreamApi : IStreamApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIStreamApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("GetRemoteFile(string filename)", requestBuilder.BuildRestResultFuncForMethod("GetRemoteFile", new Type[] { typeof(string) }));
            methodImpls.Add("GetRemoteFileWithMetadata(string filename)", requestBuilder.BuildRestResultFuncForMethod("GetRemoteFileWithMetadata", new Type[] { typeof(string) }));
        }

        /// <inheritdoc />
        public virtual Task<Stream> GetRemoteFile(string filename)
        {
            var arguments = new object[] { filename };
            return (Task<Stream>) methodImpls["GetRemoteFile(string filename)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<Stream>> GetRemoteFileWithMetadata(string filename)
        {
            var arguments = new object[] { filename };
            return (Task<ApiResponse<Stream>>) methodImpls["GetRemoteFileWithMetadata(string filename)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIUseOverloadedGenericMethods<TResponse, TParam, THeader> : IUseOverloadedGenericMethods<TResponse, TParam, THeader>
        where TResponse : class
        where THeader : struct
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIUseOverloadedGenericMethods(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("Get()", requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  }));
            methodImpls.Add("Get(TParam param,THeader header)", requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(TParam),typeof(THeader) }));
            methodImpls.Add("Get(THeader param,TParam header)", requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(THeader),typeof(TParam) }));
            methodImpls.Add("Get(int httpstatuscode)", requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(int) }));
        }

        /// <inheritdoc />
        public virtual Task<string> Get()
        {
            var arguments = new object[] {  };
            return (Task<string>) methodImpls["Get()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(TParam param,THeader header)
        {
            var arguments = new object[] { param,header };
            return (Task<TResponse>) methodImpls["Get(TParam param,THeader header)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(THeader param,TParam header)
        {
            var arguments = new object[] { param,header };
            return (Task<TResponse>) methodImpls["Get(THeader param,TParam header)"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> Get(int httpstatuscode)
        {
            var arguments = new object[] { httpstatuscode };
            return (Task<HttpResponseMessage>) methodImpls["Get(int httpstatuscode)"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIUseOverloadedMethods : IUseOverloadedMethods
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls = new Dictionary<string, Func<HttpClient, object[], object>>();

        public AutoGeneratedIUseOverloadedMethods(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            methodImpls.Add("Get()", requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  }));
            methodImpls.Add("Get(int httpstatuscode)", requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(int) }));
        }

        /// <inheritdoc />
        public virtual Task<string> Get()
        {
            var arguments = new object[] {  };
            return (Task<string>) methodImpls["Get()"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> Get(int httpstatuscode)
        {
            var arguments = new object[] { httpstatuscode };
            return (Task<HttpResponseMessage>) methodImpls["Get(int httpstatuscode)"](Client, arguments);
        }

    }
}
