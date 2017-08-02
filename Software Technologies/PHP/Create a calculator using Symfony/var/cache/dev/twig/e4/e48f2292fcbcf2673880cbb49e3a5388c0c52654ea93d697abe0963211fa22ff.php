<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_d21a1cc2cf6e6ea37535ab53b212d6f82192bd37991b56c7587081a04fcac228 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_2c8c8d3abe236aa188bdc7ef3fed13dbddd5a943b5e50192f5ea0552c738468a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2c8c8d3abe236aa188bdc7ef3fed13dbddd5a943b5e50192f5ea0552c738468a->enter($__internal_2c8c8d3abe236aa188bdc7ef3fed13dbddd5a943b5e50192f5ea0552c738468a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_2c8c8d3abe236aa188bdc7ef3fed13dbddd5a943b5e50192f5ea0552c738468a->leave($__internal_2c8c8d3abe236aa188bdc7ef3fed13dbddd5a943b5e50192f5ea0552c738468a_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_ce918a373098040f6734b88c977206b66b18a732686ef6fb3f7d9609342bd268 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ce918a373098040f6734b88c977206b66b18a732686ef6fb3f7d9609342bd268->enter($__internal_ce918a373098040f6734b88c977206b66b18a732686ef6fb3f7d9609342bd268_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_ce918a373098040f6734b88c977206b66b18a732686ef6fb3f7d9609342bd268->leave($__internal_ce918a373098040f6734b88c977206b66b18a732686ef6fb3f7d9609342bd268_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_2b6fb18f0a902dec2139cad0b0a38a9c98b5636418052cf9551d451117f2262e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2b6fb18f0a902dec2139cad0b0a38a9c98b5636418052cf9551d451117f2262e->enter($__internal_2b6fb18f0a902dec2139cad0b0a38a9c98b5636418052cf9551d451117f2262e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_2b6fb18f0a902dec2139cad0b0a38a9c98b5636418052cf9551d451117f2262e->leave($__internal_2b6fb18f0a902dec2139cad0b0a38a9c98b5636418052cf9551d451117f2262e_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_1252b84f41275344ddc7684740d37cd167a272c6805d60bad5e05a33327edfbe = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1252b84f41275344ddc7684740d37cd167a272c6805d60bad5e05a33327edfbe->enter($__internal_1252b84f41275344ddc7684740d37cd167a272c6805d60bad5e05a33327edfbe_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_1252b84f41275344ddc7684740d37cd167a272c6805d60bad5e05a33327edfbe->leave($__internal_1252b84f41275344ddc7684740d37cd167a272c6805d60bad5e05a33327edfbe_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
