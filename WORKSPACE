workspace(name = "newsreader", managed_directories = {"@npm": ["node_modules"]})

load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")
load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet",
    commit = "e37a6053726e6b0a6a204489c70809739dae8f50",
)

http_archive(
    name = "build_bazel_rules_nodejs",
    sha256 = "452bef42c4b2fbe0f509a2699ffeb3ae2c914087736b16314dbd356f3641d7e5",
    urls = ["https://github.com/bazelbuild/rules_nodejs/releases/download/2.3.0/rules_nodejs-2.3.0.tar.gz"],
)

http_archive(
    name = "build_bazel_rules_svelte",
    url = "https://github.com/thelgevold/rules_svelte/archive/0.20.zip",
    strip_prefix = "rules_svelte-0.20",
    sha256 = "1dd44fa67570822a46ad8210af413578b7a8f3f64e810a8be193103bb0eba481"
)

load("@build_bazel_rules_nodejs//:index.bzl", "node_repositories", "yarn_install")

node_repositories()

yarn_install(
    name = "npm",
    package_json = "//:package.json",
    yarn_lock = "//:yarn.lock",
)

load("@io_bazel_rules_dotnet//dotnet:deps.bzl", "dotnet_repositories")

load("@build_bazel_rules_svelte//:defs.bzl", "rules_svelte_dependencies")
rules_svelte_dependencies()

dotnet_repositories()

load(
    "@io_bazel_rules_dotnet//dotnet:defs.bzl",
    "DEFAULT_DOTNET_CORE_FRAMEWORK",
    "DOTNET_CORE_FRAMEWORKS",
    "DOTNET_NET_FRAMEWORKS",
    "core_register_sdk",
    "dotnet_register_toolchains",
    "dotnet_repositories_nugets",
    "mono_register_sdk",
    "net_gac4",
    "net_register_sdk",
    "nuget_package"
)

dotnet_register_toolchains()

dotnet_repositories_nugets()

core_register_sdk(
    DEFAULT_DOTNET_CORE_FRAMEWORK,
)

core_register_sdk(
    DEFAULT_DOTNET_CORE_FRAMEWORK,
    name = "core_sdk",
)
